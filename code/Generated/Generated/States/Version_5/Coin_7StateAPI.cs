// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public static class Coin_7StateAPI
    {
        public static bool Active(GameObject obj) => Coin_7StateStorage.IsActive(obj);
        public static bool Collected(GameObject obj) => Coin_7StateStorage.IsCollected(obj);

        public static void SetActive(GameObject obj) => Coin_7StateStorage.SetActive(obj);
        public static void SetCollected(GameObject obj) => Coin_7StateStorage.SetCollected(obj);
    }
}
