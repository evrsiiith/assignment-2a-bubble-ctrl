// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class Coin_2Initializer : MonoBehaviour
    {
        public Coin_2StateEnum initialState = Coin_2StateEnum.Active;

        void Awake()
        {
            Coin_2StateStorage.Register(gameObject, initialState);
        }
    }
}
