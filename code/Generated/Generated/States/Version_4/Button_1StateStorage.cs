// GENERATED FILE — DO NOT EDIT
using UnityEngine;
using System;
using System.Collections.Generic;

namespace Version_4
{
    public static class Button_1StateStorage
    {
        private static Dictionary<GameObject, Button_1StateEnum> stateTable = new();

        public static event Action<GameObject, Button_1StateEnum> OnStateChanged;

        public static void Register(GameObject obj, Button_1StateEnum initialState)
        {
            if (!stateTable.ContainsKey(obj))
                stateTable.Add(obj, initialState);
        }

        public static Button_1StateEnum Get(GameObject obj) => stateTable[obj];

        public static bool IsIdle(GameObject obj) => stateTable[obj] == Button_1StateEnum.Idle;
        public static bool IsPressed(GameObject obj) => stateTable[obj] == Button_1StateEnum.Pressed;

        public static void SetIdle(GameObject obj) => SetState(obj, Button_1StateEnum.Idle);
        public static void SetPressed(GameObject obj) => SetState(obj, Button_1StateEnum.Pressed);

        private static void SetState(GameObject obj, Button_1StateEnum newState)
        {
            if (stateTable[obj] != newState)
            {
                stateTable[obj] = newState;
                OnStateChanged?.Invoke(obj, newState);
            }
        }
    }
}
