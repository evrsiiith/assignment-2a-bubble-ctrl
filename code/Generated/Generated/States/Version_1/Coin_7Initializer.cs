// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class Coin_7Initializer : MonoBehaviour
    {
        public Coin_7StateEnum initialState = Coin_7StateEnum.Active;

        void Awake()
        {
            Coin_7StateStorage.Register(gameObject, initialState);
        }
    }
}
