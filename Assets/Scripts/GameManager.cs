using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public SlotMachine slotMachine;
    public Text balanceText;
    public Text winText;
    public int balance = 1000;
    public int betAmount = 10;

    public void OnSpinButton()
    {
        if (balance >= betAmount)
        {
            balance -= betAmount;
            UpdateUI();
            slotMachine.Spin();
        }
    }

    public void AddWin(int amount)
    {
        balance += amount;
        winText.text = "Win: " + amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        balanceText.text = "Balance: " + balance;
    }
}
