// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class Coin_9Initializer : MonoBehaviour
    {
        public Coin_9StateEnum initialState = Coin_9StateEnum.Active;

        void Awake()
        {
            Coin_9StateStorage.Register(gameObject, initialState);
        }
    }
}
