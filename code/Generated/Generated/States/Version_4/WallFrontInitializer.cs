// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public class WallFrontInitializer : MonoBehaviour
    {
        public WallFrontStateEnum initialState = WallFrontStateEnum.Ready;

        void Awake()
        {
            WallFrontStateStorage.Register(gameObject, initialState);
        }
    }
}
