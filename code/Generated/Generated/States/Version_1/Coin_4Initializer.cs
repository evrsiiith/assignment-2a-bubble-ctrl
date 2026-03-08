// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class Coin_4Initializer : MonoBehaviour
    {
        public Coin_4StateEnum initialState = Coin_4StateEnum.Active;

        void Awake()
        {
            Coin_4StateStorage.Register(gameObject, initialState);
        }
    }
}
