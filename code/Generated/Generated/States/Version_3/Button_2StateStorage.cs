// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_3
{
    public static class Button_2StateStorage
    {
        private static Dictionary<GameObject, Button_2StateEnum> stateTable = new();

        public static event Action<GameObject, Button_2StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Button_2StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Button_2StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsIdle(GameObject obj) => stateTable[obj] == Button_2StateEnum.Idle;
        public static bool IsPressed(GameObject obj) => stateTable[obj] == Button_2StateEnum.Pressed;

        public static void SetIdle(GameObject obj) => SetState(obj, Button_2StateEnum.Idle);
        public static void SetPressed(GameObject obj) => SetState(obj, Button_2StateEnum.Pressed);

        private static void SetState(GameObject obj, Button_2StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
