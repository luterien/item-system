using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Item Asset")]
public class ItemAsset : ScriptableObject
{
    [Header("Basic Info")]
    public string Name;
    public Sprite Icon;

    [Header("Properties")]
    public ItemRarity Rarity;
    public ItemType Type;

    public Item GenerateItem()
    {
        return new Item(this);
    }
}