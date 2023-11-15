using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

namespace Shop
{

    public class Shop_UI : MonoBehaviour
    {
        public GameObject ShopPanel;
        public GameObject ShowDaisy;
        public GameObject ShowRose;
        ShopLogic ShopLogicScript;

        void Start()
        {
            ShopLogicScript = GameObject.FindGameObjectWithTag("Shop").GetComponent<ShopLogic>();
        }

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

        // All flowers Display
        public void ToggleDaisy()
        {
            if (!ShowDaisy.activeSelf)
            {
                ShowRose.SetActive(false);
                ShowDaisy.SetActive(true);
                ShopLogicScript.ResetBuySection();
            }
        }
        public void ToggleRose()
        {
            if (!ShowRose.activeSelf)
            {
                ShowDaisy.SetActive(false);
                ShowRose.SetActive(true);
                ShopLogicScript.ResetBuySection();
            }
        }

    }
}

