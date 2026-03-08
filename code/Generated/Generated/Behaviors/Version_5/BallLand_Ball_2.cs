// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class BallLand_Ball_2 : MonoBehaviour
    {
        void Update()
        {
            if ((Ball_2StateStorage.Get(GameObject.Find("Ball_2")) == Ball_2StateEnum.Bouncing && UserAlgorithms.IsBallAtRest(GameObject.Find("Ball_2"))))
            {
                UserAlgorithms.SetBallResting(GameObject.Find("Ball_2"));
            }
        }
    }
}
