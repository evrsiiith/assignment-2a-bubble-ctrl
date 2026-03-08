// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_5
{
    public static class RestrictedWallLeftStateStorage
    {
        private static Dictionary<GameObject, RestrictedWallLeftStateEnum> stateTable = new();

        public static event Action<GameObject, RestrictedWallLeftStateEnum> OnStateChanged;

        public static void Register(GameObject obj, RestrictedWallLeftStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static RestrictedWallLeftStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == RestrictedWallLeftStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, RestrictedWallLeftStateEnum.Ready);

        private static void SetState(GameObject obj, RestrictedWallLeftStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
