// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_3
{
    public static class StreetLight_RStateStorage
    {
        private static Dictionary<GameObject, StreetLight_RStateEnum> stateTable = new();

        public static event Action<GameObject, StreetLight_RStateEnum> OnStateChanged;

        public static void Register(GameObject obj, StreetLight_RStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static StreetLight_RStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsOff(GameObject obj) => stateTable[obj] == StreetLight_RStateEnum.Off;
        public static bool IsOn(GameObject obj) => stateTable[obj] == StreetLight_RStateEnum.On;

        public static void SetOff(GameObject obj) => SetState(obj, StreetLight_RStateEnum.Off);
        public static void SetOn(GameObject obj) => SetState(obj, StreetLight_RStateEnum.On);

        private static void SetState(GameObject obj, StreetLight_RStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
