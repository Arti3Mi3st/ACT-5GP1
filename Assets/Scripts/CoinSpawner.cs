using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform CoinSpawnPoint1, CoinSpawnPoint2, CoinSpawnPoint3, CoinSpawnPoint4, CoinSpawnPoint5;


    void Start()
    {
        StartCoroutine(SpawnCoin());
    }

    IEnumerator SpawnCoin()
    {
        yield return new WaitForSeconds(2f);

        Instantiate(coinPrefab, CoinSpawnPoint1.position, CoinSpawnPoint1.rotation);

        Instantiate(coinPrefab, CoinSpawnPoint2.position, CoinSpawnPoint2.rotation);

        Instantiate(coinPrefab, CoinSpawnPoint3.position, CoinSpawnPoint3.rotation);

        Instantiate(coinPrefab, CoinSpawnPoint4.position, CoinSpawnPoint4.rotation);

        Instantiate(coinPrefab, CoinSpawnPoint5.position, CoinSpawnPoint5.rotation);
    }
}
