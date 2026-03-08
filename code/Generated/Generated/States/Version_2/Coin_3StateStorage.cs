// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_2
{
    public static class Coin_3StateStorage
    {
        private static Dictionary<GameObject, Coin_3StateEnum> stateTable = new();

        public static event Action<GameObject, Coin_3StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Coin_3StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Coin_3StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsActive(GameObject obj) => stateTable[obj] == Coin_3StateEnum.Active;
        public static bool IsCollected(GameObject obj) => stateTable[obj] == Coin_3StateEnum.Collected;

        public static void SetActive(GameObject obj) => SetState(obj, Coin_3StateEnum.Active);
        public static void SetCollected(GameObject obj) => SetState(obj, Coin_3StateEnum.Collected);

        private static void SetState(GameObject obj, Coin_3StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
