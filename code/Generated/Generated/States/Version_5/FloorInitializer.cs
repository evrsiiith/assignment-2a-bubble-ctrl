// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class FloorInitializer : MonoBehaviour
    {
        public FloorStateEnum initialState = FloorStateEnum.Pre_spawned;

        void Awake()
        {
            FloorStateStorage.Register(gameObject, initialState);
        }
    }
}
