using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Shop
{
    public class ShopLogic : MonoBehaviour
    {
        public int quantity;
        public ItemType itemType;
        public TextMeshProUGUI quantityText;
        public int totalAmount;
        public TextMeshProUGUI totalAmountText;
        public GameObject ShowDaisy;
        public GameObject ShowRose;
        Currency currencyScript;
        PlayerScript playerScript;

        void Awake()
        {
            currencyScript = GameObject.FindGameObjectWithTag("Currency").GetComponent<Currency>();
            playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        }
        void Start()
        {
            itemType = ItemType.DAISY_SEED;
            quantity = 0;
        }

        private ItemType getSeedType()
        {
            if (ShowDaisy.activeSelf)
            {
                return ItemType.DAISY_SEED;
            }
            else if (ShowRose.activeSelf)
            {
                return ItemType.ROSE_SEED;
            }
            return ItemType.NONE;
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
            itemType = getSeedType();
            totalAmount = quantity * Item.GetCost(itemType);
            totalAmountText.text = "Total: $" + totalAmount.ToString();
        }

        public void Buy()
        {
            if (currencyScript.money >= totalAmount)
            {
                currencyScript.SubtractMoney(totalAmount);
                playerScript.playerInventory.Add(itemType, quantity);
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
