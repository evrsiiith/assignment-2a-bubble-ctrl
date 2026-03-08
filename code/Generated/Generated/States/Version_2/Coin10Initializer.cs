// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public class Coin10Initializer : MonoBehaviour
    {
        public Coin10StateEnum initialState = Coin10StateEnum.Active;

        void Awake()
        {
            Coin10StateStorage.Register(gameObject, initialState);
        }
    }
}
