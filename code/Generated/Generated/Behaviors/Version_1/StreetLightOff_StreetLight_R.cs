// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class StreetLightOff_StreetLight_R : MonoBehaviour
    {
        void Update()
        {
            if ((StreetLight_RStateStorage.Get(GameObject.Find("StreetLight_R")) == StreetLight_RStateEnum.On && UserAlgorithms.IsObjectClicked(GameObject.Find("StreetLight_R"))))
            {
                UserAlgorithms.TurnLightOff(GameObject.Find("StreetLight_R"));
            }
        }
    }
}
