// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class Coin_3Initializer : MonoBehaviour
    {
        public Coin_3StateEnum initialState = Coin_3StateEnum.Active;

        void Awake()
        {
            Coin_3StateStorage.Register(gameObject, initialState);
        }
    }
}
