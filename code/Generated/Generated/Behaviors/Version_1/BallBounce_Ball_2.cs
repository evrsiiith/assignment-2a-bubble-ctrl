// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class BallBounce_Ball_2 : MonoBehaviour
    {
        void Update()
        {
            if ((Ball_2StateStorage.Get(GameObject.Find("Ball_2")) == Ball_2StateEnum.Resting && UserAlgorithms.IsObjectClicked(GameObject.Find("Ball_2"))))
            {
                UserAlgorithms.BounceBall(GameObject.Find("Ball_2"));
            }
        }
    }
}
