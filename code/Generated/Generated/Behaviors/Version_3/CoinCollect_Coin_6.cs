// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_3
{
    public class CoinCollect_Coin_6 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin_6StateStorage.Get(GameObject.Find("Coin_6")) == Coin_6StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin_6"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin_6"));
            }
        }
    }
}
