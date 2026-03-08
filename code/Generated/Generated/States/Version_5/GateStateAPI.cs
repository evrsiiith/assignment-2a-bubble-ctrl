// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public static class GateStateAPI
    {
        public static bool Locked(GameObject obj) => GateStateStorage.IsLocked(obj);
        public static bool Unlocked(GameObject obj) => GateStateStorage.IsUnlocked(obj);

        public static void SetLocked(GameObject obj) => GateStateStorage.SetLocked(obj);
        public static void SetUnlocked(GameObject obj) => GateStateStorage.SetUnlocked(obj);
    }
}
