// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
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
