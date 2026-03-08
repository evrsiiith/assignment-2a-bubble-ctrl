// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_4
{
    public static class GateStateStorage
    {
        private static Dictionary<GameObject, GateStateEnum> stateTable = new();

        public static event Action<GameObject, GateStateEnum> OnStateChanged;

        public static void Register(GameObject obj, GateStateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static GateStateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsLocked(GameObject obj) => stateTable[obj] == GateStateEnum.Locked;
        public static bool IsUnlocked(GameObject obj) => stateTable[obj] == GateStateEnum.Unlocked;

        public static void SetLocked(GameObject obj) => SetState(obj, GateStateEnum.Locked);
        public static void SetUnlocked(GameObject obj) => SetState(obj, GateStateEnum.Unlocked);

        private static void SetState(GameObject obj, GateStateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
