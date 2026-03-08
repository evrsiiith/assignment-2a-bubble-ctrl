// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_3
{
    public static class WallFrontStateStorage
    {
        private static Dictionary<GameObject, WallFrontStateEnum> stateTable = new();

        public static event Action<GameObject, WallFrontStateEnum> OnStateChanged;

        public static void Register(GameObject obj, WallFrontStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static WallFrontStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == WallFrontStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, WallFrontStateEnum.Ready);

        private static void SetState(GameObject obj, WallFrontStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
