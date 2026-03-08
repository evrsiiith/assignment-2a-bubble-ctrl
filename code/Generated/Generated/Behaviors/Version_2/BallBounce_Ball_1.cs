// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public class BallBounce_Ball_1 : MonoBehaviour
    {
        void Update()
        {
            if ((Ball_1StateStorage.Get(GameObject.Find("Ball_1")) == Ball_1StateEnum.Resting && UserAlgorithms.IsObjectClicked(GameObject.Find("Ball_1"))))
            {
                UserAlgorithms.BounceBall(GameObject.Find("Ball_1"));
            }
        }
    }
}
