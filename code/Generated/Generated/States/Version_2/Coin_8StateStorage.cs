// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_2
{
    public static class Coin_8StateStorage
    {
        private static Dictionary<GameObject, Coin_8StateEnum> stateTable = new();

        public static event Action<GameObject, Coin_8StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Coin_8StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Coin_8StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsActive(GameObject obj) => stateTable[obj] == Coin_8StateEnum.Active;
        public static bool IsCollected(GameObject obj) => stateTable[obj] == Coin_8StateEnum.Collected;

        public static void SetActive(GameObject obj) => SetState(obj, Coin_8StateEnum.Active);
        public static void SetCollected(GameObject obj) => SetState(obj, Coin_8StateEnum.Collected);

        private static void SetState(GameObject obj, Coin_8StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
