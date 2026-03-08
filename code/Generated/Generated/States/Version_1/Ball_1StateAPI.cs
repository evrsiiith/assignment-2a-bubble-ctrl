// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public static class Ball_1StateAPI
    {
        public static bool Resting(GameObject obj) => Ball_1StateStorage.IsResting(obj);
        public static bool Bouncing(GameObject obj) => Ball_1StateStorage.IsBouncing(obj);

        public static void SetResting(GameObject obj) => Ball_1StateStorage.SetResting(obj);
        public static void SetBouncing(GameObject obj) => Ball_1StateStorage.SetBouncing(obj);
    }
}
