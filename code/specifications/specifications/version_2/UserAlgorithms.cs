using UnityEngine;
using System.Collections.Generic;
using VReqDV;

namespace Version_2
{
    public static class UserAlgorithms
    {
        private static int _coinCount = 0;
        private static readonly Dictionary<string, float> _ballBounceTime = new Dictionary<string, float>();

        // --- Common Utility ---
        public static bool IsObjectClicked(GameObject obj)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out RaycastHit hit))
                {
                    return hit.collider.gameObject == obj;
                }
            }
            return false;
        }

        // --- Street Lights ---
        public static void ToggleLight(GameObject obj)
        {
            bool isOn = StateAccessor.IsState(obj.name, "on", obj, "Version_2");
            if (isOn)
            {
                Light light = obj.GetComponent<Light>();
                if (light != null) light.enabled = false;
                Renderer rend = obj.GetComponent<Renderer>();
                if (rend != null) rend.material.color = new Color(0.2f, 0.2f, 0.2f);
                StateAccessor.SetState(obj.name, "off", obj, "Version_2");
                Debug.Log($"[StreetLight] {obj.name} toggled OFF");
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
                StateAccessor.SetState(obj.name, "on", obj, "Version_2");
                Debug.Log($"[StreetLight] {obj.name} toggled ON");
            }
        }

        // --- Balls ---
        public static void BounceBall(GameObject obj)
        {
            _ballBounceTime[obj.name] = Time.time;

            Collider col = obj.GetComponent<Collider>();
            if (col != null)
            {
                PhysicMaterial mat = new PhysicMaterial("BallBouncy");
                mat.bounciness = 0.75f;
                mat.dynamicFriction = 0.3f;
                mat.staticFriction = 0.3f;
                mat.frictionCombine = PhysicMaterialCombine.Minimum;
                mat.bounceCombine = PhysicMaterialCombine.Maximum;
                col.material = mat;
            }

            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.AddForce(Vector3.up * 9f, ForceMode.Impulse);
            }

            StateAccessor.SetState(obj.name, "bouncing", obj, "Version_2");
            Debug.Log($"[Ball] {obj.name} bounce triggered");
        }

        public static bool IsBallAtRest(GameObject obj)
        {
            if (_ballBounceTime.TryGetValue(obj.name, out float t) && Time.time - t < 1.0f)
                return false;

            Rigidbody rb = obj.GetComponent<Rigidbody>();
            return rb == null || rb.velocity.magnitude < 0.1f;
        }

        public static void SetBallResting(GameObject obj)
        {
            StateAccessor.SetState(obj.name, "resting", obj, "Version_2");
        }

        // --- Coins ---
        public static void CollectCoin(GameObject obj)
        {
            _coinCount++;
            Debug.Log($"[Coins] {obj.name} collected! Total: {_coinCount}/10");
            StateAccessor.SetState(obj.name, "collected", obj, "Version_2");
            obj.SetActive(false);
        }

        public static bool HasCollectedAllCoins()
        {
            return _coinCount >= 10;
        }

        // --- Gate ---
        public static void OpenGate(GameObject obj)
        {
            Debug.Log("[Gate] Opening! All 10 coins collected.");
            obj.transform.position = new Vector3(
                obj.transform.position.x,
                obj.transform.position.y + 5f,
                obj.transform.position.z
            );
            StateAccessor.SetState("Gate", "unlocked", obj, "Version_2");
        }

        // --- Buttons ---
        public static void PressButton(GameObject obj)
        {
            Renderer rend = obj.GetComponent<Renderer>();
            if (rend != null)
                rend.material.color = Color.green;

            StateAccessor.SetState(obj.name, "pressed", obj, "Version_2");
            Debug.Log($"[Button] {obj.name} pressed!");
        }
    }
}
