// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_5
{
    public static class WallGapRStateStorage
    {
        private static Dictionary<GameObject, WallGapRStateEnum> stateTable = new();

        public static event Action<GameObject, WallGapRStateEnum> OnStateChanged;

        public static void Register(GameObject obj, WallGapRStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static WallGapRStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == WallGapRStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, WallGapRStateEnum.Ready);

        private static void SetState(GameObject obj, WallGapRStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
