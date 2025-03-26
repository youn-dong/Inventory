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
        equippedItems = new Dictionary<ItemType, Item>(); // 딕셔너리를 통해 아이템의 타입에 따라서 장착할 수 있는 장착 아이템 딕셔너리를 생성
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
    public void AddItem(Item newitem) // 인벤토리에 아이템 추가하기
    {
        if(newitem != null)
        {
            Inventory.Add(newitem);
        }
    }
    public void EquipItem(Item item) // 아이템 장착할 때
    {
        if (item != null && Inventory.Contains(item)) //아이템이 있는지와 인벤토리에 존재하는지를 체크하고
        {
            if (equippedItems.ContainsKey(item.ItemType)) // 장착한 아이템을 저장하는 딕셔너리에 아이템 종류를 확인하고,
                                                          // 이미 장착이 되어있다면 내가 현재 선택한 아이템을 장착 아이템으로
            {
                equippedItems[item.ItemType] = item;
            }

            else
            {
                equippedItems.Add(item.ItemType, item); //만약 아이템종류에 장착이 되어있지 않다면 장착하고, 딕셔너리에 장착아이템의 데이터를 추가
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
        return equippedItems.ContainsKey(item.ItemType) && equippedItems[item.ItemType] == item; //딕셔너리에 등록된 장착 아이템이 실제 아이템과 동일한지 체크
    }
}
