// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class ButtonReset_Button_1 : MonoBehaviour
    {
        void Update()
        {
            if ((Button_1StateStorage.Get(GameObject.Find("Button_1")) == Button_1StateEnum.Pressed && UserAlgorithms.IsButtonTimedOut(GameObject.Find("Button_1"))))
            {
                UserAlgorithms.ResetButton(GameObject.Find("Button_1"));
            }
        }
    }
}
