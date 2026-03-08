// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_5
{
    public static class WallLeftStateStorage
    {
        private static Dictionary<GameObject, WallLeftStateEnum> stateTable = new();

        public static event Action<GameObject, WallLeftStateEnum> OnStateChanged;

        public static void Register(GameObject obj, WallLeftStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static WallLeftStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == WallLeftStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, WallLeftStateEnum.Ready);

        private static void SetState(GameObject obj, WallLeftStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
