using TMPro;
using UnityEngine;

public class CountingCoins : MonoBehaviour
{
    public int CurrentCoins {  get; private set; }
    [SerializeField] private TMP_Text _coinsText;

    public void IncreaseCoin(int coin) {
        CurrentCoins += coin;
        DisplayCoinsOnUI(_coinsText);
    }

    public void DisplayCoinsOnUI (TMP_Text coinsText) =>
        coinsText.text = "Coins: " + CurrentCoins.ToString();
}
