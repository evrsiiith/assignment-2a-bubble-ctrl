// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public class Coin_6Initializer : MonoBehaviour
    {
        public Coin_6StateEnum initialState = Coin_6StateEnum.Active;

        void Awake()
        {
            Coin_6StateStorage.Register(gameObject, initialState);
        }
    }
}
