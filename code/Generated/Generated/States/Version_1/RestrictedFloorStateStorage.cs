// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_1
{
    public static class RestrictedFloorStateStorage
    {
        private static Dictionary<GameObject, RestrictedFloorStateEnum> stateTable = new();

        public static event Action<GameObject, RestrictedFloorStateEnum> OnStateChanged;

        public static void Register(GameObject obj, RestrictedFloorStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static RestrictedFloorStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsReady(GameObject obj) => stateTable[obj] == RestrictedFloorStateEnum.Ready;

        public static void SetReady(GameObject obj) => SetState(obj, RestrictedFloorStateEnum.Ready);

        private static void SetState(GameObject obj, RestrictedFloorStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
