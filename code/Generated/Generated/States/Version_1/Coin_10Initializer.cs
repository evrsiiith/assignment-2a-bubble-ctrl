// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class Coin_10Initializer : MonoBehaviour
    {
        public Coin_10StateEnum initialState = Coin_10StateEnum.Active;

        void Awake()
        {
            Coin_10StateStorage.Register(gameObject, initialState);
        }
    }
}
