// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_5
{
    public static class WallGapLStateStorage
    {
        private static Dictionary<GameObject, WallGapLStateEnum> stateTable = new();

        public static event Action<GameObject, WallGapLStateEnum> OnStateChanged;

        public static void Register(GameObject obj, WallGapLStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static WallGapLStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == WallGapLStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, WallGapLStateEnum.Ready);

        private static void SetState(GameObject obj, WallGapLStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
