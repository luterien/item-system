using UnityEngine;
using System.Collections;

namespace ItemSystem.Inventory.Core
{
    [CreateAssetMenu(menuName = "Item Actions/Equip")]
    public class EquipItem : ItemAction
    {
        InventoryUser InventoryUser;

        public override void Execute(Item item)
        {
            if (InventoryUser == null)
                InventoryUser = FindObjectOfType<InventoryUser>();

            InventoryUser.Equip(item);
        }
    }
}