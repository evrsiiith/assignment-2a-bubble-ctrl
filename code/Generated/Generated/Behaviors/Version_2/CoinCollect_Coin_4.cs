// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_2
{
    public class CoinCollect_Coin_4 : MonoBehaviour
    {
        void Update()
        {
            if ((Coin_4StateStorage.Get(GameObject.Find("Coin_4")) == Coin_4StateEnum.Active && UserAlgorithms.IsObjectClicked(GameObject.Find("Coin_4"))))
            {
                UserAlgorithms.CollectCoin(GameObject.Find("Coin_4"));
            }
        }
    }
}
