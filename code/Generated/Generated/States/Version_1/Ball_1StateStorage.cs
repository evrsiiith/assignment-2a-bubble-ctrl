// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_1
{
    public static class Ball_1StateStorage
    {
        private static Dictionary<GameObject, Ball_1StateEnum> stateTable = new();

        public static event Action<GameObject, Ball_1StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Ball_1StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Ball_1StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsResting(GameObject obj) => stateTable[obj] == Ball_1StateEnum.Resting;
        public static bool IsBouncing(GameObject obj) => stateTable[obj] == Ball_1StateEnum.Bouncing;

        public static void SetResting(GameObject obj) => SetState(obj, Ball_1StateEnum.Resting);
        public static void SetBouncing(GameObject obj) => SetState(obj, Ball_1StateEnum.Bouncing);

        private static void SetState(GameObject obj, Ball_1StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
