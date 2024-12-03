using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerScript : MonoBehaviour
{
    public Inventory playerInventory;
    public Currency currencyScript;


    public void Awake()
    {
        playerInventory = new Inventory(9);
        currencyScript = GameObject.FindGameObjectWithTag("Currency").GetComponent<Currency>();
    }
    public void Start()
    {

    }
    public void Update()
    {
    }
}
