// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class Ball_2Initializer : MonoBehaviour
    {
        public Ball_2StateEnum initialState = Ball_2StateEnum.Resting;

        void Awake()
        {
            Ball_2StateStorage.Register(gameObject, initialState);
        }
    }
}
