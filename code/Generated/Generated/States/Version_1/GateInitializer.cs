// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class GateInitializer : MonoBehaviour
    {
        public GateStateEnum initialState = GateStateEnum.Locked;

        void Awake()
        {
            GateStateStorage.Register(gameObject, initialState);
        }
    }
}
