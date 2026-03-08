// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public class RestrictedWallRightInitializer : MonoBehaviour
    {
        public RestrictedWallRightStateEnum initialState = RestrictedWallRightStateEnum.Ready;

        void Awake()
        {
            RestrictedWallRightStateStorage.Register(gameObject, initialState);
        }
    }
}
