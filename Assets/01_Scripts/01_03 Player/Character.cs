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
}
