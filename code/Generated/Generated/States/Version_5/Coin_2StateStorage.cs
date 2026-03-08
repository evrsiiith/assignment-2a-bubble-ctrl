// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_5
{
    public static class Coin_2StateStorage
    {
        private static Dictionary<GameObject, Coin_2StateEnum> stateTable = new();

        public static event Action<GameObject, Coin_2StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Coin_2StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Coin_2StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsActive(GameObject obj) => stateTable[obj] == Coin_2StateEnum.Active;
        public static bool IsCollected(GameObject obj) => stateTable[obj] == Coin_2StateEnum.Collected;

        public static void SetActive(GameObject obj) => SetState(obj, Coin_2StateEnum.Active);
        public static void SetCollected(GameObject obj) => SetState(obj, Coin_2StateEnum.Collected);

        private static void SetState(GameObject obj, Coin_2StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
