// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class BallDragStart_Ball_2 : MonoBehaviour
    {
        void Update()
        {
            if (((Ball_2StateStorage.Get(GameObject.Find("Ball_2")) == Ball_2StateEnum.Resting || Ball_2StateStorage.Get(GameObject.Find("Ball_2")) == Ball_2StateEnum.Bouncing) && UserAlgorithms.IsDragInitiated(GameObject.Find("Ball_2"))))
            {
                UserAlgorithms.StartDrag(GameObject.Find("Ball_2"));
            }
        }
    }
}
