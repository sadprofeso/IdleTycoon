using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyUI;
    public BigInteger Money { get; private set; }

    public static MoneyManager instance;
    
    private void UpdateMoneyUI()
    {
        moneyUI.text = string.Format("{0} Dollar", Money);
    }



    void Start()
    {
        Money = 0;
        UpdateMoneyUI();
        instance = this;
    }

    public bool Buy(BigInteger cost)
    {
        bool isBuySuccessfull = false;

        if (cost <= Money)
        {
            Money -= cost;
            isBuySuccessfull = true;
        }

        UpdateMoneyUI();
        return isBuySuccessfull;
    }

    public void AddMoney(BigInteger profit)
    {
        if (profit > 0)
        {
            Money += profit;
            UpdateMoneyUI();
        }
    }

    void Update()
    {
        
    }
}
