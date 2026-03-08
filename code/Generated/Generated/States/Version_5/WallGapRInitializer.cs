// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class WallGapRInitializer : MonoBehaviour
    {
        public WallGapRStateEnum initialState = WallGapRStateEnum.Ready;

        void Awake()
        {
            WallGapRStateStorage.Register(gameObject, initialState);
        }
    }
}
