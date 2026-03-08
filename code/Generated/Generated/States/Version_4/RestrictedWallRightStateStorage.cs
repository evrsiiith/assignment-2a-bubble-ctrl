// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_4
{
    public static class RestrictedWallRightStateStorage
    {
        private static Dictionary<GameObject, RestrictedWallRightStateEnum> stateTable = new();

        public static event Action<GameObject, RestrictedWallRightStateEnum> OnStateChanged;

        public static void Register(GameObject obj, RestrictedWallRightStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static RestrictedWallRightStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == RestrictedWallRightStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, RestrictedWallRightStateEnum.Ready);

        private static void SetState(GameObject obj, RestrictedWallRightStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
