using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Shop_UI : MonoBehaviour
{
    public GameObject ShopPanel;
    public GameObject ShowDaisy;
    public GameObject ShowRose;
    public TextMeshProUGUI quantityText;
    public int quantity;
    public TextMeshProUGUI totalAmountText;
    public int totalAmount;
    public Currency currency;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ToggleShop();
        }
    }
    public void ToggleShop()
    {
        ShopPanel.SetActive(!ShopPanel.activeSelf);
    }

    // Buy Section
    public void AddFlower()
    {
        if (quantity < 99)
        {
            quantity += 1;
            quantityText.text = quantity.ToString();
            UpdateTotal();
        }
    }
    public void SubtractFlower()
    {
        if (quantity > 0)
        {
            quantity -= 1;
            quantityText.text = quantity.ToString();
            UpdateTotal();

        }
    }
    public void UpdateTotal()
    {
        Item.ItemType itemType = Item.ItemType.NONE;
        if (ShowDaisy.activeSelf)
        {
            itemType = Item.ItemType.DAISY_SEED;
        }
        else if (ShowRose.activeSelf)
        {
            itemType = Item.ItemType.ROSE_SEED;

        }
        totalAmount = quantity * Item.GetCost(itemType);
        totalAmountText.text = "Total: $" + totalAmount.ToString();
    }

    public void Buy()
    {

    }
    public void resetBuySection()
    {
        quantity = 0;
        quantityText.text = "0";
        totalAmount = 0;
        totalAmountText.text = "Total: $0";
    }


    // All flowers Display
    public void ToggleDaisy()
    {
        if (!ShowDaisy.activeSelf)
        {
            ShowRose.SetActive(false);
            ShowDaisy.SetActive(true);
            resetBuySection();

        }
    }
    public void ToggleRose()
    {
        if (!ShowRose.activeSelf)
        {
            ShowDaisy.SetActive(false);
            ShowRose.SetActive(true);
            resetBuySection();
        }
    }


}

