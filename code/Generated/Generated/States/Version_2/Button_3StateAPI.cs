// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public static class Button_3StateAPI
    {
        public static bool Idle(GameObject obj) => Button_3StateStorage.IsIdle(obj);
        public static bool Pressed(GameObject obj) => Button_3StateStorage.IsPressed(obj);

        public static void SetIdle(GameObject obj) => Button_3StateStorage.SetIdle(obj);
        public static void SetPressed(GameObject obj) => Button_3StateStorage.SetPressed(obj);
    }
}
