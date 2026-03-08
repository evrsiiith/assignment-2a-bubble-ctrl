// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public class RestrictedWallLeftInitializer : MonoBehaviour
    {
        public RestrictedWallLeftStateEnum initialState = RestrictedWallLeftStateEnum.Ready;

        void Awake()
        {
            RestrictedWallLeftStateStorage.Register(gameObject, initialState);
        }
    }
}
