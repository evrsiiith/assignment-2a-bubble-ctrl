// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class ButtonPress_Button_2 : MonoBehaviour
    {
        void Update()
        {
            if ((Button_2StateStorage.Get(GameObject.Find("Button_2")) == Button_2StateEnum.Idle && GateStateStorage.Get(GameObject.Find("Gate")) == GateStateEnum.Unlocked && UserAlgorithms.IsObjectClicked(GameObject.Find("Button_2"))))
            {
                UserAlgorithms.PressButton(GameObject.Find("Button_2"));
            }
        }
    }
}
