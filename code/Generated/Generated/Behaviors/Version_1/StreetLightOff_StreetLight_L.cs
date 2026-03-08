// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class StreetLightOff_StreetLight_L : MonoBehaviour
    {
        void Update()
        {
            if ((StreetLight_LStateStorage.Get(GameObject.Find("StreetLight_L")) == StreetLight_LStateEnum.On && UserAlgorithms.IsObjectClicked(GameObject.Find("StreetLight_L"))))
            {
                UserAlgorithms.TurnLightOff(GameObject.Find("StreetLight_L"));
            }
        }
    }
}
