// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public static class Coin_9StateAPI
    {
        public static bool Active(GameObject obj) => Coin_9StateStorage.IsActive(obj);
        public static bool Collected(GameObject obj) => Coin_9StateStorage.IsCollected(obj);

        public static void SetActive(GameObject obj) => Coin_9StateStorage.SetActive(obj);
        public static void SetCollected(GameObject obj) => Coin_9StateStorage.SetCollected(obj);
    }
}
