using UnityEngine;
using System.Collections;
using ItemSystem.Inventory.Core;

public class InventoryUser : AbstractInventoryUser
{
    [Header("Components")]
    public Inventory Inventory;
    public Equipment Equipment;

    [Header("UI Components")]
    public InventoryUI InventoryUI;
    public EquipmentUI EquipmentUI;

    override public bool Add(Item item)
    {
        try
        {
            return Inventory.Add(item);
        }
        catch (InventoryIsFull)
        {
            return false;
        }
    }

    override public void Remove(Item item)
    {
        Inventory.Remove(item);
    }

    override public void Equip(Item item)
    {
        if (item == null)
            return;

        if (Inventory.Remove(item))
        {
            Item itemToUnequip = Equipment.Load(item);

            if (itemToUnequip != null)
            {
                Inventory.Add(itemToUnequip);
            }

            InventoryUI.Reload();
        }
    }

    override public void Unequip(Item item)
    {
        if (item == null)
            return;

        try
        {
            if (Inventory.Add(item))
                Equipment.Unload(item);

            InventoryUI.Reload();
        }
        catch (InventoryIsFull) { }
    }
}
