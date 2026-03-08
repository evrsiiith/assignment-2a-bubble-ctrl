// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public static class FloorStateAPI
    {
        public static bool Pre_spawned(GameObject obj) => FloorStateStorage.IsPre_spawned(obj);
        public static bool Ready(GameObject obj) => FloorStateStorage.IsReady(obj);

        public static void SetPre_spawned(GameObject obj) => FloorStateStorage.SetPre_spawned(obj);
        public static void SetReady(GameObject obj) => FloorStateStorage.SetReady(obj);
    }
}
