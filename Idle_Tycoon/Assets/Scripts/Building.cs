using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Numerics;


public class Building : MonoBehaviour
{

    [SerializeField] private GameObject buildingVisuals;
    [SerializeField] private GameObject buyButton;

    private TextMeshProUGUI buyButtonText;

    [SerializeField] private string costRepresentation;
    
    public BigInteger Cost
    {
        get { return BigInteger.Parse(costRepresentation);  }
        set { costRepresentation = value.ToString();  }
    }

    private bool isUnlocked = false;



    void Start()
    {
        buyButtonText = buyButton.GetComponentInChildren<TextMeshProUGUI>();
    }

    void Update()
    {
        
    }
}
