// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class BallDragStart_Ball_1 : MonoBehaviour
    {
        void Update()
        {
            if (((Ball_1StateStorage.Get(GameObject.Find("Ball_1")) == Ball_1StateEnum.Resting || Ball_1StateStorage.Get(GameObject.Find("Ball_1")) == Ball_1StateEnum.Bouncing) && UserAlgorithms.IsDragInitiated(GameObject.Find("Ball_1"))))
            {
                UserAlgorithms.StartDrag(GameObject.Find("Ball_1"));
            }
        }
    }
}
