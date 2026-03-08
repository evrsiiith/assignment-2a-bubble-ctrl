// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class WallRightInitializer : MonoBehaviour
    {
        public WallRightStateEnum initialState = WallRightStateEnum.Ready;

        void Awake()
        {
            WallRightStateStorage.Register(gameObject, initialState);
        }
    }
}
