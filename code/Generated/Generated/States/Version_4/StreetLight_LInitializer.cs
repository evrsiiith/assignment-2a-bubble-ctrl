// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public class StreetLight_LInitializer : MonoBehaviour
    {
        public StreetLight_LStateEnum initialState = StreetLight_LStateEnum.Off;

        void Awake()
        {
            StreetLight_LStateStorage.Register(gameObject, initialState);
        }
    }
}
