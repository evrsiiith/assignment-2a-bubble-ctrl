// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class Coin_5Initializer : MonoBehaviour
    {
        public Coin_5StateEnum initialState = Coin_5StateEnum.Active;

        void Awake()
        {
            Coin_5StateStorage.Register(gameObject, initialState);
        }
    }
}
