// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public class BallLand_Ball_1 : MonoBehaviour
    {
        void Update()
        {
            if ((Ball_1StateStorage.Get(GameObject.Find("Ball_1")) == Ball_1StateEnum.Bouncing && UserAlgorithms.IsBallAtRest(GameObject.Find("Ball_1"))))
            {
                UserAlgorithms.SetBallResting(GameObject.Find("Ball_1"));
            }
        }
    }
}
