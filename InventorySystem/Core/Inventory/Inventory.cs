using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ItemSystem.Inventory.Core
{
    public class Inventory : MonoBehaviour
    {
        private static int MaxItemCount = 20;

        public List<Item> Items;

        public event Action OnInventoryUpdated;

        public bool HasSpace
        {
            get { return Items.Count < MaxItemCount; }
        }

        private void Initialize()
        {
            Items = new List<Item>(new Item[MaxItemCount]);
        }

        public bool Add(Item item)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] == null)
                {
                    Items[i] = item;
                    OnInventoryUpdated?.Invoke();
                    return true;
                }
            }

            throw new InventoryIsFull();
        }

        public bool Remove(Item item)
        {
            Items[Items.IndexOf(item)] = null;
            OnInventoryUpdated?.Invoke();
            return true;
        }

        public void Refresh()
        {
            OnInventoryUpdated?.Invoke();
        }
    }
}