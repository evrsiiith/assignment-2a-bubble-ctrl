// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class StreetLight_RInitializer : MonoBehaviour
    {
        public StreetLight_RStateEnum initialState = StreetLight_RStateEnum.Off;

        void Awake()
        {
            StreetLight_RStateStorage.Register(gameObject, initialState);
        }
    }
}
