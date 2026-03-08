// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public class GateUnlock_Gate : MonoBehaviour
    {
        void Update()
        {
            if ((GateStateStorage.Get(GameObject.Find("Gate")) == GateStateEnum.Locked && UserAlgorithms.HasCollectedAllCoins() && UserAlgorithms.IsObjectClicked(GameObject.Find("Gate"))))
            {
                UserAlgorithms.OpenGate(GameObject.Find("Gate"));
            }
        }
    }
}
