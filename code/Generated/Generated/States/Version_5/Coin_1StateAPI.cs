// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public static class Coin_1StateAPI
    {
        public static bool Active(GameObject obj) => Coin_1StateStorage.IsActive(obj);
        public static bool Collected(GameObject obj) => Coin_1StateStorage.IsCollected(obj);

        public static void SetActive(GameObject obj) => Coin_1StateStorage.SetActive(obj);
        public static void SetCollected(GameObject obj) => Coin_1StateStorage.SetCollected(obj);
    }
}
