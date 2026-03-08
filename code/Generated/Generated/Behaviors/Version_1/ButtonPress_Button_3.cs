// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class ButtonPress_Button_3 : MonoBehaviour
    {
        void Update()
        {
            if ((Button_3StateStorage.Get(GameObject.Find("Button_3")) == Button_3StateEnum.Idle && GateStateStorage.Get(GameObject.Find("Gate")) == GateStateEnum.Unlocked && UserAlgorithms.IsObjectClicked(GameObject.Find("Button_3"))))
            {
                UserAlgorithms.PressButton(GameObject.Find("Button_3"));
            }
        }
    }
}
