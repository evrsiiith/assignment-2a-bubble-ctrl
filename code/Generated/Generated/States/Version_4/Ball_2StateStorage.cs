// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_4
{
    public static class Ball_2StateStorage
    {
        private static Dictionary<GameObject, Ball_2StateEnum> stateTable = new();

        public static event Action<GameObject, Ball_2StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Ball_2StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Ball_2StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsResting(GameObject obj) => stateTable[obj] == Ball_2StateEnum.Resting;
        public static bool IsBouncing(GameObject obj) => stateTable[obj] == Ball_2StateEnum.Bouncing;

        public static void SetResting(GameObject obj) => SetState(obj, Ball_2StateEnum.Resting);
        public static void SetBouncing(GameObject obj) => SetState(obj, Ball_2StateEnum.Bouncing);

        private static void SetState(GameObject obj, Ball_2StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
