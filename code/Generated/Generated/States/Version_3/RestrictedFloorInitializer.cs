// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public class RestrictedFloorInitializer : MonoBehaviour
    {
        public RestrictedFloorStateEnum initialState = RestrictedFloorStateEnum.Ready;

        void Awake()
        {
            RestrictedFloorStateStorage.Register(gameObject, initialState);
        }
    }
}
