// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public static class Coin_10StateAPI
    {
        public static bool Active(GameObject obj) => Coin_10StateStorage.IsActive(obj);
        public static bool Collected(GameObject obj) => Coin_10StateStorage.IsCollected(obj);

        public static void SetActive(GameObject obj) => Coin_10StateStorage.SetActive(obj);
        public static void SetCollected(GameObject obj) => Coin_10StateStorage.SetCollected(obj);
    }
}
