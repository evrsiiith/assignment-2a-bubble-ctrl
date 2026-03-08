// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class BallDragRelease_Ball_2 : MonoBehaviour
    {
        void Update()
        {
            if ((Ball_2StateStorage.Get(GameObject.Find("Ball_2")) == Ball_2StateEnum.Dragging && UserAlgorithms.IsDragReleased(GameObject.Find("Ball_2"))))
            {
                UserAlgorithms.ApplyDrag(GameObject.Find("Ball_2"));
            }
        }
    }
}
