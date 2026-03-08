// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public class CoinCollect_Coin_3 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin_3StateStorage.Get(GameObject.Find("Coin_3")) == Coin_3StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin_3"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin_3"));
            }
        }
    }
}
