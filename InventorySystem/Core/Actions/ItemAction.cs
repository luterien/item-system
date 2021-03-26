using UnityEngine;
using System.Collections;

namespace ItemSystem.Inventory.Core
{
    abstract public class ItemAction : ScriptableObject
    {
        abstract public void Execute(Item item);
    }

    
}