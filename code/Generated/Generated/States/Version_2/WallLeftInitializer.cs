// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public class WallLeftInitializer : MonoBehaviour
    {
        public WallLeftStateEnum initialState = WallLeftStateEnum.Ready;

        void Awake()
        {
            WallLeftStateStorage.Register(gameObject, initialState);
        }
    }
}
