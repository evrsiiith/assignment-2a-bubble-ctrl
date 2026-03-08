// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_4
{
    public static class Coin10StateStorage
    {
        private static Dictionary<GameObject, Coin10StateEnum> stateTable = new();

        public static event Action<GameObject, Coin10StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Coin10StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Coin10StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsActive(GameObject obj) => stateTable[obj] == Coin10StateEnum.Active;
        public static bool IsCollected(GameObject obj) => stateTable[obj] == Coin10StateEnum.Collected;

        public static void SetActive(GameObject obj) => SetState(obj, Coin10StateEnum.Active);
        public static void SetCollected(GameObject obj) => SetState(obj, Coin10StateEnum.Collected);

        private static void SetState(GameObject obj, Coin10StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
