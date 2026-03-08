// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_5
{
    public static class Coin_5StateStorage
    {
        private static Dictionary<GameObject, Coin_5StateEnum> stateTable = new();

        public static event Action<GameObject, Coin_5StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Coin_5StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Coin_5StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsActive(GameObject obj) => stateTable[obj] == Coin_5StateEnum.Active;
        public static bool IsCollected(GameObject obj) => stateTable[obj] == Coin_5StateEnum.Collected;

        public static void SetActive(GameObject obj) => SetState(obj, Coin_5StateEnum.Active);
        public static void SetCollected(GameObject obj) => SetState(obj, Coin_5StateEnum.Collected);

        private static void SetState(GameObject obj, Coin_5StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
