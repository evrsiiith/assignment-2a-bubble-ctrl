// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public class CoinCollect_Coin_9 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin_9StateStorage.Get(GameObject.Find("Coin_9")) == Coin_9StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin_9"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin_9"));
            }
        }
    }
}
