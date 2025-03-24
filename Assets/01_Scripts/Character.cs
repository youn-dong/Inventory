using Unity.Profiling;

public class Character 
{
    private string userName;
    private int atk;
    private int def;
    private int hp;
    private int critical;
    private int gold;
    private string description;

    public Character()
    {
        userName = "DefalutName";
        atk = 0;
        def = 0;
        hp = 100;
        critical = 5;
        gold = 10000;
        description = "";
    }
}
