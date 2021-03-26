using System;
using System.Collections.Generic;
using UnityEngine;

namespace ItemSystem.Inventory.Core
{
    abstract public class AbstractInventoryUser : MonoBehaviour
    {
        abstract public bool Add(Item item);
        abstract public void Remove(Item item);
        abstract public void Equip(Item item);
        abstract public void Unequip(Item item);
    }
}