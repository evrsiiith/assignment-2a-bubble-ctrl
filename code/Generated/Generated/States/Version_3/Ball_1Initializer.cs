// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public class Ball_1Initializer : MonoBehaviour
    {
        public Ball_1StateEnum initialState = Ball_1StateEnum.Resting;

        void Awake()
        {
            Ball_1StateStorage.Register(gameObject, initialState);
        }
    }
}
