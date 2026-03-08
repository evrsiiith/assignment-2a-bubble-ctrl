// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public class Button_3Initializer : MonoBehaviour
    {
        public Button_3StateEnum initialState = Button_3StateEnum.Idle;

        void Awake()
        {
            Button_3StateStorage.Register(gameObject, initialState);
        }
    }
}
