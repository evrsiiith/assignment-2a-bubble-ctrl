// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class CoinCollect_Coin_7 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin_7StateStorage.Get(GameObject.Find("Coin_7")) == Coin_7StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin_7"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin_7"));
            }
        }
    }
}
