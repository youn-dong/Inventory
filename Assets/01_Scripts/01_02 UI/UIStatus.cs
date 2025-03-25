using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour, IGetData
{
    [Header("캐릭터 스텟")]
    public TextMeshProUGUI atkValue;
    public TextMeshProUGUI defValue;
    public TextMeshProUGUI hpValue;
    public TextMeshProUGUI criticalValue;

    [Header("버튼")]
    public Button mainUIBtn;
    void Start()
    {
        mainUIBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SetCharacterData(Character character)
    {
        atkValue.text = $" 공격력 \n {character.Atk}";
        defValue.text = $" 방어력 \n {character.Def}";
        hpValue.text = $" 체력\n {character.MaxHp}";
        criticalValue.text = $" 치명타 \n {character.Critical}";
    }
}
