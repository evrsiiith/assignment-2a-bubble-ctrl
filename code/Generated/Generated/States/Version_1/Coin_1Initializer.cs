// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class Coin_1Initializer : MonoBehaviour
    {
        public Coin_1StateEnum initialState = Coin_1StateEnum.Active;

        void Awake()
        {
            Coin_1StateStorage.Register(gameObject, initialState);
        }
    }
}
