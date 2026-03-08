// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class CoinCollect_Coin_8 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin_8StateStorage.Get(GameObject.Find("Coin_8")) == Coin_8StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin_8"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin_8"));
            }
        }
    }
}
