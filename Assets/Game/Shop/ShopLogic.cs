using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Shop
{
    public class ShopLogic : MonoBehaviour
    {
        public int quantity;
        public TextMeshProUGUI quantityText;
        public int totalAmount;
        public TextMeshProUGUI totalAmountText;
        public GameObject ShowDaisy;
        public GameObject ShowRose;
        Currency currencyScript;
        // Start is called before the first frame update
        void Start()
        {
            currencyScript = GameObject.FindGameObjectWithTag("Currency").GetComponent<Currency>();
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
            if (currencyScript.money >= totalAmount)
            {
                currencyScript.SubtractMoney(totalAmount);
            }
            else
            {
                Debug.Log("Don't try to fool me! you can't buy that! (｡•ˇ‸ˇ•｡)");
            }
        }

        public void ResetBuySection()
        {
            quantity = 0;
            quantityText.text = "0";
            totalAmount = 0;
            totalAmountText.text = "Total: $0";
        }
    }
}
