// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_4
{
    public class CoinCollect_Coin_1 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin_1StateStorage.Get(GameObject.Find("Coin_1")) == Coin_1StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin_1"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin_1"));
            }
        }
    }
}
