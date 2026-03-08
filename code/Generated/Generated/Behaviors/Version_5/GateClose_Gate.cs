// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class GateClose_Gate : MonoBehaviour
    {
        void Update()
        {
            if ((GateStateStorage.Get(GameObject.Find("Gate")) == GateStateEnum.Unlocked && UserAlgorithms.IsObjectClicked(GameObject.Find("Gate"))))
            {
                UserAlgorithms.CloseGate(GameObject.Find("Gate"));
            }
        }
    }
}
