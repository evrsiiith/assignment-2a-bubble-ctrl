// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public static class Coin10StateAPI
    {
        public static bool Active(GameObject obj) => Coin10StateStorage.IsActive(obj);
        public static bool Collected(GameObject obj) => Coin10StateStorage.IsCollected(obj);

        public static void SetActive(GameObject obj) => Coin10StateStorage.SetActive(obj);
        public static void SetCollected(GameObject obj) => Coin10StateStorage.SetCollected(obj);
    }
}
