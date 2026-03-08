// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_2
{
    public static class WallRightStateStorage
    {
        private static Dictionary<GameObject, WallRightStateEnum> stateTable = new();

        public static event Action<GameObject, WallRightStateEnum> OnStateChanged;

        public static void Register(GameObject obj, WallRightStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static WallRightStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == WallRightStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, WallRightStateEnum.Ready);

        private static void SetState(GameObject obj, WallRightStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
