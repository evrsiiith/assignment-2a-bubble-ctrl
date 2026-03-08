// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public static class Ball_2StateAPI
    {
        public static bool Resting(GameObject obj) => Ball_2StateStorage.IsResting(obj);
        public static bool Bouncing(GameObject obj) => Ball_2StateStorage.IsBouncing(obj);
        public static bool Dragging(GameObject obj) => Ball_2StateStorage.IsDragging(obj);

        public static void SetResting(GameObject obj) => Ball_2StateStorage.SetResting(obj);
        public static void SetBouncing(GameObject obj) => Ball_2StateStorage.SetBouncing(obj);
        public static void SetDragging(GameObject obj) => Ball_2StateStorage.SetDragging(obj);
    }
}
