using System.Collections.Generic;

public class Character 
{
    public string UserName { get; private set; }
    public int Atk { get; private set;}
    public int Def { get; private set;}
    public int MaxHp { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }
    public string Description { get; private set; }
    public int MaxExp { get; private set; }
    public int CurExp { get; private set; }
    public int Level { get; private set; }
    public List<Item> Inventory { get; private set; }
    public Dictionary<ItemType, Item> equippedItems { get; private set; }

    public Character(string userName, int atk, int def, int maxHp, int critical, int gold, string description, int level, int curExp, int maxExp)
    {
        UserName = userName;
        Atk = atk;
        Def = def;
        MaxHp = maxHp;
        Critical = critical;
        Gold = gold;
        Description = description;
        Level = level;
        CurExp = curExp;
        MaxExp = maxExp;

        Inventory = new List<Item>();
        equippedItems = new Dictionary<ItemType, Item>(); // 딕셔너리를 통해 아이템의 타입에 따라서 장착을 할 수 있도록 만들기 위함.
    }
    public void LevelUp(int exp)
    {
        CurExp += exp; //얻은 경험치만큼
        while(CurExp >= MaxExp)
        {
            CurExp -= MaxExp;
            Level++;
            MaxExp += 5;
        }
    }
    public void AddItem(Item newitem) //
    {
        if(newitem != null)
        {
            Inventory.Add(newitem);
        }
    }
    public void EquipItem(Item item)
    {
        if (item != null && Inventory.Contains(item))
        {
            if (equippedItems.ContainsKey(item.ItemType))
            {
                equippedItems[item.ItemType] = item;
            }

            else
            {
                equippedItems.Add(item.ItemType, item);
            }
        }
    }
    public void UnEquipItem(Item item)
    {
        if (item != null && equippedItems.ContainsKey(item.ItemType) && equippedItems[item.ItemType] == item)
        {
            equippedItems.Remove(item.ItemType);
        }
    }
    public bool IsItemEquipped(Item item)
    {
        if(item == null) //현재 장착된 아이템이 있는지 없는지를 체크
        {
            return false;
        }
        return item != null && equippedItems.ContainsKey(item.ItemType) && equippedItems[item.ItemType] == item;
    }
}
