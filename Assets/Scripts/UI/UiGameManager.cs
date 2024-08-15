using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiGameManager : MonoBehaviour
{
    [SerializeField] private CountingCoins _countingCoins;
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private Button _pauseButton;
    [SerializeField] private Button _continueButton;

    private void Start()
    {
        _pauseButton.onClick.AddListener(PauseGame);
        _continueButton.onClick.AddListener(ContinueGame);
    }

    private void PauseGame()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    private void ContinueGame()
    {
        Time.timeScale = 1f;
        _pauseMenu.SetActive(false);
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + _countingCoins.CurrentCoins);
        SceneManager.LoadScene("Menu");
    }
}
