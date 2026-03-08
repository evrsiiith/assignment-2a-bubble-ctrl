// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class ButtonReset_Button_3 : MonoBehaviour
    {
        void Update()
        {
            if ((Button_3StateStorage.Get(GameObject.Find("Button_3")) == Button_3StateEnum.Pressed && UserAlgorithms.IsButtonTimedOut(GameObject.Find("Button_3"))))
            {
                UserAlgorithms.ResetButton(GameObject.Find("Button_3"));
            }
        }
    }
}
