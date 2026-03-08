// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public class Coin10Initializer : MonoBehaviour
    {
        public Coin10StateEnum initialState = Coin10StateEnum.Active;

        void Awake()
        {
            Coin10StateStorage.Register(gameObject, initialState);
        }
    }
}
