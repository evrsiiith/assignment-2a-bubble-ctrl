// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class CoinInit_Floor : MonoBehaviour
    {
        void Update()
        {
            if (FloorStateStorage.Get(GameObject.Find("Floor")) == FloorStateEnum.Pre_spawned)
            {
                UserAlgorithms.InitCoins(GameObject.Find("Floor"));
            }
        }
    }
}
