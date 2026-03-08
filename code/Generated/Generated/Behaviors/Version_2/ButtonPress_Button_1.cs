// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public class ButtonPress_Button_1 : MonoBehaviour
    {
        void Update()
        {
            if ((Button_1StateStorage.Get(GameObject.Find("Button_1")) == Button_1StateEnum.Idle && GateStateStorage.Get(GameObject.Find("Gate")) == GateStateEnum.Unlocked && UserAlgorithms.IsObjectClicked(GameObject.Find("Button_1"))))
            {
                UserAlgorithms.PressButton(GameObject.Find("Button_1"));
            }
        }
    }
}
