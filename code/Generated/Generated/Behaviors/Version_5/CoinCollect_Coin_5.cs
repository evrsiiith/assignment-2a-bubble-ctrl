// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class CoinCollect_Coin_5 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin_5StateStorage.Get(GameObject.Find("Coin_5")) == Coin_5StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin_5"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin_5"));
            }
        }
    }
}
