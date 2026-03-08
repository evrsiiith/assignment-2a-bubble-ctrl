// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public class StreetLightToggle_StreetLight_R : MonoBehaviour
    {
        void Update()
        {
            if (UserAlgorithms.IsObjectClicked(GameObject.Find("StreetLight_R")))
            {
                UserAlgorithms.ToggleLight(GameObject.Find("StreetLight_R"));
            }
        }
    }
}
