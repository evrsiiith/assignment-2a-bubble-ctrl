// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public class Button_2Initializer : MonoBehaviour
    {
        public Button_2StateEnum initialState = Button_2StateEnum.Idle;

        void Awake()
        {
            Button_2StateStorage.Register(gameObject, initialState);
        }
    }
}
