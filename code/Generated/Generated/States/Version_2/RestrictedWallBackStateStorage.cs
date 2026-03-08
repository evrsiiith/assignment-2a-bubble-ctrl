// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_2
{
    public static class RestrictedWallBackStateStorage
    {
        private static Dictionary<GameObject, RestrictedWallBackStateEnum> stateTable = new();

        public static event Action<GameObject, RestrictedWallBackStateEnum> OnStateChanged;

        public static void Register(GameObject obj, RestrictedWallBackStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static RestrictedWallBackStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == RestrictedWallBackStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, RestrictedWallBackStateEnum.Ready);

        private static void SetState(GameObject obj, RestrictedWallBackStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
