// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_1
{
    public class CoinCollect_Coin_2 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin_2StateStorage.Get(GameObject.Find("Coin_2")) == Coin_2StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin_2"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin_2"));
            }
        }
    }
}
