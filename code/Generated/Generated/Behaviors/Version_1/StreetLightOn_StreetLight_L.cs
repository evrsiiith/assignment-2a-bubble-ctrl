// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class StreetLightOn_StreetLight_L : MonoBehaviour
    {
        void Update()
        {
            if ((StreetLight_LStateStorage.Get(GameObject.Find("StreetLight_L")) == StreetLight_LStateEnum.Off && UserAlgorithms.IsObjectClicked(GameObject.Find("StreetLight_L"))))
            {
                UserAlgorithms.TurnLightOn(GameObject.Find("StreetLight_L"));
            }
        }
    }
}
