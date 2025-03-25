using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Character Player { get; private set; }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return; 
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Start()
    {
        SetData();
    }
    public void SetData()
    {
        //생성자를 통해 받은 매개변수로 객체 생성
        Player = new Character( 
            userName: "홍길동",
            atk: 15,
            def: 10,
            maxHp: 100,
            critical: 20,
            gold: 10000,
            description: "시대를 거스르는 동해번쩍 서해번쩍입니다.",
            level: 1,
            curExp: 3,
            maxExp: 10
        );
        //각종 Canvas에 데이터 전달
        UIManager.Instance.MainMenu.SetCharacterData(Player);
        UIManager.Instance.Status.SetCharacterData(Player);
    }
}
