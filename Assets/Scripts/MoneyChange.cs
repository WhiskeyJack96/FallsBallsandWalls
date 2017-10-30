using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyChange : MonoBehaviour
{
    public Player2Controller Player2;
    public UnityEngine.UI.Text MoneyText;

    private void Start()
    {
        MoneyText = GetComponent<UnityEngine.UI.Text>();
        //Player2 = GetComponent<Player2Controller>();
    }

    public void MoneyDisplay()
    {
        print("ddd");
        MoneyText.text = "$ " + Player2.money.ToString();
    }
}
