using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static int coinsCollected = 0;
    public GameObject Door;

    void Start()
    {
        coinsCollected = 0;

        Door.SetActive(false);
    }

    void Update()
    {
        if(coinsCollected >= 5)
        {
            Door.SetActive(true);
        }    
    }
}
