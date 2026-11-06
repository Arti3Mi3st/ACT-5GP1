using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public GameObject _Character;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            if(CoinManager.coinsCollected >= 5)
            {
                SceneManager.LoadScene("WinScene");
            }
        }
    }
}
