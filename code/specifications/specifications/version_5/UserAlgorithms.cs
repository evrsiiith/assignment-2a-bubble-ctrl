using UnityEngine;
using System.Collections.Generic;
using VReqDV;

namespace Version_5
{
    public static class UserAlgorithms
    {
        private static int _coinCount = 0;
        private static float _lastSpawnTime = 0f;
        private static readonly string[] _coinNames = {
            "Coin_1", "Coin_2", "Coin_3", "Coin_4", "Coin_5",
            "Coin_6", "Coin_7", "Coin_8", "Coin_9", "Coin10"
        };
        private static readonly Dictionary<string, Vector3> _dragStartScreen = new Dictionary<string, Vector3>();
        private static readonly Dictionary<string, bool> _dragging = new Dictionary<string, bool>();
        private static readonly Dictionary<string, float> _dragReleaseTime = new Dictionary<string, float>();
        private static readonly Dictionary<string, float> _buttonPressTime = new Dictionary<string, float>();
        // Cache coin references before hiding so GameObject.Find (which skips inactive objects) isn't needed later
        private static readonly Dictionary<string, GameObject> _coinCache = new Dictionary<string, GameObject>();

        // --- Init (runs once: Floor pre_spawned -> ready) ---
        public static void InitCoins(GameObject obj)
        {
            _coinCount = 0;
            _dragging.Clear();
            _dragStartScreen.Clear();
            _dragReleaseTime.Clear();
            _buttonPressTime.Clear();
            _coinCache.Clear();
            // Cache while coins are still active — Find cannot locate inactive objects
            foreach (var name in _coinNames)
            {
                GameObject c = GameObject.Find(name);
                if (c != null)
                {
                    _coinCache[name] = c;
                    StateAccessor.SetState(name, "collected", c, "Version_5");
                    c.SetActive(false);
                }
            }
            // Colour the restricted floor orange as a visual marker
            GameObject rf = GameObject.Find("RestrictedFloor");
            if (rf != null)
            {
                Renderer rfRend = rf.GetComponent<Renderer>();
                if (rfRend != null) rfRend.material.color = new Color(1f, 0.5f, 0f);
            }
            // Tint the gate yellow so it stands out
            GameObject gate = GameObject.Find("Gate");
            if (gate != null)
            {
                Renderer gRend = gate.GetComponent<Renderer>();
                if (gRend != null) gRend.material.color = new Color(1f, 0.9f, 0f);
            }
            _lastSpawnTime = Time.time;
            StateAccessor.SetState("Floor", "ready", obj, "Version_5");
            Debug.Log("[Init] All coins hidden. Spawner starts in 4s.");
        }

        // --- Coin Spawner ---
        public static bool IsSpawnTime()
        {
            if (Time.time - _lastSpawnTime < 4f) return false;
            int active = 0;
            foreach (var n in _coinNames)
            {
                if (_coinCache.TryGetValue(n, out GameObject c) && c != null && c.activeSelf)
                    active++;
            }
            return active < 7;
        }

        public static void SpawnNextCoin(GameObject obj)
        {
            foreach (var n in _coinNames)
            {
                // Use cached reference — Find() skips inactive GameObjects
                if (!_coinCache.TryGetValue(n, out GameObject c) || c == null || c.activeSelf)
                    continue;
                {
                    Vector3 pos;
                    int attempts = 0;
                    do
                    {
                        pos = new Vector3(
                            Random.Range(-8f, 8f),
                            0.2f,
                            Random.Range(3f, 18f)
                        );
                        attempts++;
                    } while (Physics.OverlapSphere(pos, 0.8f).Length > 0 && attempts < 50);
                    c.transform.position = pos;
                    c.SetActive(true);
                    StateAccessor.SetState(n, "active", c, "Version_5");
                    _lastSpawnTime = Time.time;
                    Debug.Log($"[Spawner] {n} spawned at {pos}");
                    return;
                }
            }
            _lastSpawnTime = Time.time;
        }

        // --- Common Utility ---
        public static bool IsObjectClicked(GameObject obj)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hit))
                    return hit.collider.gameObject == obj;
            }
            return false;
        }

        // --- Street Lights ---
        public static void ToggleLight(GameObject obj)
        {
            bool isOn = StateAccessor.IsState(obj.name, "on", obj, "Version_5");
            if (isOn)
            {
                Light light = obj.GetComponent<Light>();
                if (light != null) light.enabled = false;
                Renderer rend = obj.GetComponent<Renderer>();
                if (rend != null) rend.material.color = new Color(0.2f, 0.2f, 0.2f);
                StateAccessor.SetState(obj.name, "off", obj, "Version_5");
            }
            else
            {
                Light light = obj.GetComponent<Light>();
                if (light == null) light = obj.AddComponent<Light>();
                light.type = LightType.Point;
                light.color = Color.yellow;
                light.intensity = 3f;
                light.range = 15f;
                light.shadows = LightShadows.Soft;
                light.enabled = true;
                Renderer rend = obj.GetComponent<Renderer>();
                if (rend != null) rend.material.color = Color.yellow;
                StateAccessor.SetState(obj.name, "on", obj, "Version_5");
            }
        }

        // --- Balls (drag-to-launch) ---
        public static bool IsDragInitiated(GameObject obj)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hit) && hit.collider.gameObject == obj)
                {
                    _dragStartScreen[obj.name] = Input.mousePosition;
                    _dragging[obj.name] = true;
                    return true;
                }
            }
            return false;
        }

        public static void StartDrag(GameObject obj)
        {
            StateAccessor.SetState(obj.name, "dragging", obj, "Version_5");
            Debug.Log($"[Ball] {obj.name} drag started");
        }

        public static bool IsDragReleased(GameObject obj)
        {
            return _dragging.ContainsKey(obj.name) && _dragging[obj.name]
                && Input.GetMouseButtonUp(0);
        }

        public static void ApplyDrag(GameObject obj)
        {
            if (!_dragStartScreen.ContainsKey(obj.name)) return;
            Vector3 delta = (Vector3)Input.mousePosition - _dragStartScreen[obj.name];
            Vector3 dir = Camera.main.transform.right   * delta.x
                        + Camera.main.transform.forward * delta.y;
            dir.y = 0f;
            if (dir.magnitude > 0.01f) dir.Normalize();
            float strength = Mathf.Clamp(delta.magnitude * 0.05f, 3f, 15f);

            Collider col = obj.GetComponent<Collider>();
            if (col != null)
            {
                PhysicMaterial mat = new PhysicMaterial("BallFriction")
                {
                    bounciness       = 0.4f,
                    dynamicFriction  = 0.5f,
                    staticFriction   = 0.5f,
                    frictionCombine  = PhysicMaterialCombine.Average,
                    bounceCombine    = PhysicMaterialCombine.Average
                };
                col.material = mat;
            }

            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.AddForce((dir + Vector3.up * 0.5f) * strength, ForceMode.Impulse);
            }
            _dragging[obj.name] = false;
            _dragReleaseTime[obj.name] = Time.time;
            StateAccessor.SetState(obj.name, "bouncing", obj, "Version_5");
            Debug.Log($"[Ball] {obj.name} launched: dir={dir}, strength={strength}");
        }

        public static bool IsBallAtRest(GameObject obj)
        {
            if (_dragReleaseTime.TryGetValue(obj.name, out float t) && Time.time - t < 1.5f)
                return false;
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            return rb == null || (rb.velocity.magnitude < 0.05f && rb.angularVelocity.magnitude < 0.05f);
        }

        public static void SetBallResting(GameObject obj)
        {
            StateAccessor.SetState(obj.name, "resting", obj, "Version_5");
        }

        // --- Coins ---
        public static void CollectCoin(GameObject obj)
        {
            _coinCount++;
            Debug.Log($"[Coins] {obj.name} collected. Total: {_coinCount}");
            StateAccessor.SetState(obj.name, "collected", obj, "Version_5");
            obj.SetActive(false);
        }

        public static bool HasEnoughCoins()
        {
            return _coinCount >= 10;
        }

        // --- Gate (open costs 10 coins, click again to close) ---
        public static void OpenGate(GameObject obj)
        {
            _coinCount -= 10;
            Debug.Log($"[Gate] Opened. Coins remaining: {_coinCount}");
            obj.transform.position = new Vector3(
                obj.transform.position.x,
                obj.transform.position.y + 5f,
                obj.transform.position.z
            );
            StateAccessor.SetState("Gate", "unlocked", obj, "Version_5");
        }

        public static void CloseGate(GameObject obj)
        {
            Debug.Log("[Gate] Closed.");
            obj.transform.position = new Vector3(
                obj.transform.position.x,
                obj.transform.position.y - 5f,
                obj.transform.position.z
            );
            StateAccessor.SetState("Gate", "locked", obj, "Version_5");
        }

        // --- Buttons (color flash 1 second: Button_1=red, Button_2=green, Button_3=blue) ---
        public static void PressButton(GameObject obj)
        {
            Color c = obj.name == "Button_1" ? Color.red
                    : obj.name == "Button_2" ? Color.green
                    : Color.blue;
            Renderer rend = obj.GetComponent<Renderer>();
            if (rend != null) rend.material.color = c;
            _buttonPressTime[obj.name] = Time.time;
            StateAccessor.SetState(obj.name, "pressed", obj, "Version_5");
            Debug.Log($"[Button] {obj.name} pressed!");
        }

        public static bool IsButtonTimedOut(GameObject obj)
        {
            return _buttonPressTime.ContainsKey(obj.name)
                && Time.time - _buttonPressTime[obj.name] >= 1f;
        }

        public static void ResetButton(GameObject obj)
        {
            Renderer rend = obj.GetComponent<Renderer>();
            if (rend != null) rend.material.color = Color.white;
            StateAccessor.SetState(obj.name, "idle", obj, "Version_5");
            Debug.Log($"[Button] {obj.name} reset.");
        }
    }
}
