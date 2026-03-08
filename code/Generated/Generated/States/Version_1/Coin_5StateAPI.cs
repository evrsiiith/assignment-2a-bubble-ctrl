// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public static class Coin_5StateAPI
    {
        public static bool Active(GameObject obj) => Coin_5StateStorage.IsActive(obj);
        public static bool Collected(GameObject obj) => Coin_5StateStorage.IsCollected(obj);

        public static void SetActive(GameObject obj) => Coin_5StateStorage.SetActive(obj);
        public static void SetCollected(GameObject obj) => Coin_5StateStorage.SetCollected(obj);
    }
}
