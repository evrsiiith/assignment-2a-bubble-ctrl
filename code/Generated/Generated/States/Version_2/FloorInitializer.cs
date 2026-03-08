// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public class FloorInitializer : MonoBehaviour
    {
        public FloorStateEnum initialState = FloorStateEnum.Ready;

        void Awake()
        {
            FloorStateStorage.Register(gameObject, initialState);
        }
    }
}
