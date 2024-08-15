using UnityEngine;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private int _denomination;
    [SerializeField] private CountingCoins _countingCoins;

    private void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            _countingCoins.IncreaseCoin(_denomination);
            Destroy(gameObject);
        }
    }
}
