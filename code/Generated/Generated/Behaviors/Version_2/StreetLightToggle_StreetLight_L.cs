// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public class StreetLightToggle_StreetLight_L : MonoBehaviour
    {
        void Update()
        {
            if (UserAlgorithms.IsObjectClicked(GameObject.Find("StreetLight_L")))
            {
                UserAlgorithms.ToggleLight(GameObject.Find("StreetLight_L"));
            }
        }
    }
}
