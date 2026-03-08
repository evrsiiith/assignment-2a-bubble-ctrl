// GENERATED FILE — DO NOT EDIT
using UnityEngine;

namespace Version_5
{
    public class CoinSpawner_Floor : MonoBehaviour
    {
        void Update()
        {
            if ((FloorStateStorage.Get(GameObject.Find("Floor")) == FloorStateEnum.Ready && UserAlgorithms.IsSpawnTime()))
            {
                UserAlgorithms.SpawnNextCoin(GameObject.Find("Floor"));
            }
        }
    }
}
