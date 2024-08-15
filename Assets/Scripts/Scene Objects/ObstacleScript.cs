using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverMenu;

    private void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            _gameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
