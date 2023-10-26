using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        NONE, DAISY_SEED, ROSE_SEED
    }
    public static int GetCost(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.DAISY_SEED: return 1;
            case ItemType.ROSE_SEED: return 5;
            default: return 0;
        }
    }

}
