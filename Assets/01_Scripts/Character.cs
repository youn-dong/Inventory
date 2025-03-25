public class Character 
{
    public string UserName { get; private set; }
    public int Atk { get; private set;}
    public int Def { get; private set;}
    public int MaxHp { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }
    public string description;
    public int MaxExp { get; private set; }
    public int CurExp { get; private set; }
    public int Level { get; private set; }
    public Character()
    {
        UserName = "DefalutName";
        Level = 1;
        CurExp = 0;
        Atk = 0;
        Def = 0;
        MaxHp = 100;
        Critical = 5;
        Gold = 10000;
        description = "";
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
