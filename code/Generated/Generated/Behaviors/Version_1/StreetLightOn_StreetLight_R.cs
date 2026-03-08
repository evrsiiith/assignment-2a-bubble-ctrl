// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class StreetLightOn_StreetLight_R : MonoBehaviour
    {
        void Update()
        {
            if ((StreetLight_RStateStorage.Get(GameObject.Find("StreetLight_R")) == StreetLight_RStateEnum.Off && UserAlgorithms.IsObjectClicked(GameObject.Find("StreetLight_R"))))
            {
                UserAlgorithms.TurnLightOn(GameObject.Find("StreetLight_R"));
            }
        }
    }
}
