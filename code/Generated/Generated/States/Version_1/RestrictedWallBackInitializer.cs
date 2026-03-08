// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class RestrictedWallBackInitializer : MonoBehaviour
    {
        public RestrictedWallBackStateEnum initialState = RestrictedWallBackStateEnum.Ready;

        void Awake()
        {
            RestrictedWallBackStateStorage.Register(gameObject, initialState);
        }
    }
}
