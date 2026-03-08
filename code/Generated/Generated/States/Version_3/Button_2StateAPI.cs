// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public static class Button_2StateAPI
    {
        public static bool Idle(GameObject obj) => Button_2StateStorage.IsIdle(obj);
        public static bool Pressed(GameObject obj) => Button_2StateStorage.IsPressed(obj);

        public static void SetIdle(GameObject obj) => Button_2StateStorage.SetIdle(obj);
        public static void SetPressed(GameObject obj) => Button_2StateStorage.SetPressed(obj);
    }
}
