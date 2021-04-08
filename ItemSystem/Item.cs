using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item : ISerializationCallbackReceiver
{
    public string Name;

    [NonSerialized]
    public Sprite Icon;
    public string IconName;

    [NonSerialized]
    public ItemRarity Rarity;
    public string RarityName;

    [NonSerialized]
    public ItemType Type;
    public string TypeName;

    public Item(ItemAsset source)
    {
        Name = source.Name;
        Rarity = source.Rarity;
        Type = source.Type;
    }

    virtual public void OnAfterDeserialize()
    {
        Icon = Resources.Load<Sprite>("Data/Sprites/Items/" + IconName);
        Type = Resources.Load<ItemType>("Data/Items/Types/" + TypeName);
        Rarity = Resources.Load<ItemRarity>("Data/Items/Rarity/" + RarityName);
    }

    virtual public void OnBeforeSerialize()
    {
        IconName = Icon.name;
        RarityName = Rarity.name;
        TypeName = Type.name;
    }
}