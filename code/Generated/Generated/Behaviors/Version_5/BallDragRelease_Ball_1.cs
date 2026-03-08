// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class BallDragRelease_Ball_1 : MonoBehaviour
    {
        void Update()
        {
            if ((Ball_1StateStorage.Get(GameObject.Find("Ball_1")) == Ball_1StateEnum.Dragging && UserAlgorithms.IsDragReleased(GameObject.Find("Ball_1"))))
            {
                UserAlgorithms.ApplyDrag(GameObject.Find("Ball_1"));
            }
        }
    }
}
