using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Threading;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public int money;
    public TextMeshProUGUI moneyText;
    void Awake()
    {
        money = 10;
    }

    public string DisplayCurrency(int money)
    {
        int moneyLenght = money.ToString().Length;
        switch (moneyLenght)
        {
            case 7: return $"{money.ToString()[0]}M";
            case 8: return $"{money.ToString()[0]}{money.ToString()[1]}M";
            case 9: return $"{money.ToString()[0]}{money.ToString()[1]}{money.ToString()[2]}M";
            default: return money.ToString();
        }
    }
    public void AddMoney(int moneyToAdd)
    {
        money += moneyToAdd;
        moneyText.text = "$" + DisplayCurrency(money);
    }

    public void SubtractMoney(int moneyToSubtract)
    {
        money -= moneyToSubtract;
        moneyText.text = "$" + DisplayCurrency(money);
    }
}
