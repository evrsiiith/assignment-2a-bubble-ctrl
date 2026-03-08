// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public class Coin_8Initializer : MonoBehaviour
    {
        public Coin_8StateEnum initialState = Coin_8StateEnum.Active;

        void Awake()
        {
            Coin_8StateStorage.Register(gameObject, initialState);
        }
    }
}
