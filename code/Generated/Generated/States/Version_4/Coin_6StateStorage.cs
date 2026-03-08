// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_4
{
    public static class Coin_6StateStorage
    {
        private static Dictionary<GameObject, Coin_6StateEnum> stateTable = new();

        public static event Action<GameObject, Coin_6StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Coin_6StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Coin_6StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsActive(GameObject obj) => stateTable[obj] == Coin_6StateEnum.Active;
        public static bool IsCollected(GameObject obj) => stateTable[obj] == Coin_6StateEnum.Collected;

        public static void SetActive(GameObject obj) => SetState(obj, Coin_6StateEnum.Active);
        public static void SetCollected(GameObject obj) => SetState(obj, Coin_6StateEnum.Collected);

        private static void SetState(GameObject obj, Coin_6StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
