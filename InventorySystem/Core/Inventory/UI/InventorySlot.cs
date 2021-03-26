using UnityEngine;
using System.Collections;

namespace ItemSystem.Inventory.Core
{
    abstract public class InventorySlot : MonoBehaviour
    {
        abstract public void Load(Item item);
        abstract public void Unload(Item item);
    }
}