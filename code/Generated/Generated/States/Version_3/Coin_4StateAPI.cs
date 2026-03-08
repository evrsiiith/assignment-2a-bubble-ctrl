// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public static class Coin_4StateAPI
    {
        public static bool Active(GameObject obj) => Coin_4StateStorage.IsActive(obj);
        public static bool Collected(GameObject obj) => Coin_4StateStorage.IsCollected(obj);

        public static void SetActive(GameObject obj) => Coin_4StateStorage.SetActive(obj);
        public static void SetCollected(GameObject obj) => Coin_4StateStorage.SetCollected(obj);
    }
}
