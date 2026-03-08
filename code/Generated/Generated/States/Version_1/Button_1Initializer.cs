// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class Button_1Initializer : MonoBehaviour
    {
        public Button_1StateEnum initialState = Button_1StateEnum.Idle;

        void Awake()
        {
            Button_1StateStorage.Register(gameObject, initialState);
        }
    }
}
