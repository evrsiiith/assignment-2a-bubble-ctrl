// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class GateOpen_Gate : MonoBehaviour
    {
        void Update()
        {
            if ((GateStateStorage.Get(GameObject.Find("Gate")) == GateStateEnum.Locked && UserAlgorithms.HasEnoughCoins() && UserAlgorithms.IsObjectClicked(GameObject.Find("Gate"))))
            {
                UserAlgorithms.OpenGate(GameObject.Find("Gate"));
            }
        }
    }
}
