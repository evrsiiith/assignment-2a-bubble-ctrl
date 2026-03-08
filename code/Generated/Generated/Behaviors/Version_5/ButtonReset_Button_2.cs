// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class ButtonReset_Button_2 : MonoBehaviour
    {
        void Update()
        {
            if ((Button_2StateStorage.Get(GameObject.Find("Button_2")) == Button_2StateEnum.Pressed && UserAlgorithms.IsButtonTimedOut(GameObject.Find("Button_2"))))
            {
                UserAlgorithms.ResetButton(GameObject.Find("Button_2"));
            }
        }
    }
}
