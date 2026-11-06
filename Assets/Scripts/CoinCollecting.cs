using Unity.VisualScripting;
using UnityEngine;

public class CoinCollecting : MonoBehaviour
{
    public GameObject _Character;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            CoinManager.coinsCollected++;

            Destroy(gameObject);
        }
    }
}
