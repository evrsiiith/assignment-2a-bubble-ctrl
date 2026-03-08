// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_1
{
    public static class StreetLight_LStateStorage
    {
        private static Dictionary<GameObject, StreetLight_LStateEnum> stateTable = new();

        public static event Action<GameObject, StreetLight_LStateEnum> OnStateChanged;

        public static void Register(GameObject obj, StreetLight_LStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static StreetLight_LStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsOff(GameObject obj) => stateTable[obj] == StreetLight_LStateEnum.Off;
        public static bool IsOn(GameObject obj) => stateTable[obj] == StreetLight_LStateEnum.On;

        public static void SetOff(GameObject obj) => SetState(obj, StreetLight_LStateEnum.Off);
        public static void SetOn(GameObject obj) => SetState(obj, StreetLight_LStateEnum.On);

        private static void SetState(GameObject obj, StreetLight_LStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
