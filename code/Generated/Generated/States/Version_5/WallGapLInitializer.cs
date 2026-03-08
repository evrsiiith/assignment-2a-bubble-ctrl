// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class WallGapLInitializer : MonoBehaviour
    {
        public WallGapLStateEnum initialState = WallGapLStateEnum.Ready;

        void Awake()
        {
            WallGapLStateStorage.Register(gameObject, initialState);
        }
    }
}
