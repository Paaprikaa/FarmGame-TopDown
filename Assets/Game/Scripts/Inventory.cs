using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;



// [System.Serializable]
// public class Inventory
// {
//     [System.Serializable]
//     public class Slot
//     {
//         public ItemType type;
//         public int count;
//         public int maxAllowed;

//         public Slot()
//         {
//             type = ItemType.NONE;
//             count = 0;
//             maxAllowed = 99;
//         }

//         public bool CanAddItem()
//         {
//             return count < maxAllowed;
//         }

//         public void AddItem(ItemType type)
//         {
//             this.type = type;
//             count++;
//         }
//     }

//     public List<Slot> slots = new();

//     public Inventory(int numSlots)
//     {
//         for (int i = 0; i < numSlots; i++)
//         {
//             Slot slot = new();
//             slots.Add(slot);
//         }
//     }

//     public void Add(ItemType typeToAdd)
//     {
//         foreach (Slot slot in slots)
//         {
//             if (slot.type == typeToAdd && slot.CanAddItem())
//             {
//                 slot.AddItem(typeToAdd);
//                 return;
//             }
//         }
//         foreach (Slot slot in slots)
//         {
//             if (slot.type == ItemType.NONE)
//             {
//                 slot.AddItem(typeToAdd);
//                 return;
//             }
//         }
//     }
// }



