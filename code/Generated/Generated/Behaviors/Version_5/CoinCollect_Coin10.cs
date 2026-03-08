// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class CoinCollect_Coin10 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin10StateStorage.Get(GameObject.Find("Coin10")) == Coin10StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin10"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin10"));
            }
        }
    }
}
