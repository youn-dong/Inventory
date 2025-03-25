using UnityEngine;

public enum ItemType
{
    Weapon,
    Helmet,
    Armor,
    Shoes,
    Accessory
}
public enum StatType
{
    Attack,
    Defense,
    Health,
    Critical
}
[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    [SerializeField] private string itemName;
    [SerializeField] private Sprite image;
    [SerializeField] private int maxStack;
    [SerializeField] private ItemType itemType;
    [SerializeField] private StatType statType;
    [SerializeField] private int statValue;

    public string ItemName { get { return itemName; } }
    public Sprite Image { get { return image; } }
    public int MaxStack { get { return maxStack; } }
    public ItemType ItemType { get { return itemType; } }
    public StatType StatType { get { return statType; } }
    public int StatValue { get { return statValue; } }

    public void Init(string newName, Sprite newImage, int newMaxStack, ItemType newType, StatType newStat, int newstatValue)
    {
        itemName = newName;
        image = newImage;
        maxStack = newMaxStack;
        itemType = newType;
        statType = newStat;
        statValue = newstatValue;
    }

}

