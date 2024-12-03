using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    [System.Serializable]
    public class Slot
    {
        public ItemType type;
        // how many items are in the slot
        public int count;
        public int maxAllowed;

        // constructor for Slot
        public Slot()
        {
            type = ItemType.NONE;
            count = 0;
            maxAllowed = 99;
        }

        public bool CanAddItem(int amount)
        {
            return this.count + amount <= maxAllowed;
        }

        public void AddItem(ItemType type, int amount)
        {
            this.type = type;
            count = count + amount;
        }
    }

    public List<Slot> slots = new List<Slot>();
    // constructor for Inventory, called when the object of the class is created
    public Inventory(int numSlots)
    {
        for (int i = 0; i < numSlots; i++)
        {
            Slot slot = new();
            slots.Add(slot);
        }
    }

    public void Add(ItemType typeToAdd, int amount)
    {
        // already item in inventory
        foreach (Slot slot in slots)
        {
            if (slot.type == typeToAdd && slot.CanAddItem(amount))
            {
                slot.AddItem(typeToAdd, amount);
                return;
            }
        }

        // new item in inventory
        foreach (Slot slot in slots)
        {
            if (slot.type == ItemType.NONE && slot.CanAddItem(amount))
            {
                slot.AddItem(typeToAdd, amount);
                return;
            }
        }
    }
}



