using TMPro;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private CountingCoins _countingCoins;
    [SerializeField] private TMP_Text _coinsText;

    private void Start () =>
        _countingCoins.DisplayCoinsOnUI(_coinsText);
    
}
