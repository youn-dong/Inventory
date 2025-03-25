using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour, IGetData
{
    [SerializeField] private Transform slotParent;
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
        int totalAtk = character.Atk;
        int totalDef = character.Def;
        int totalMaxHp = character.MaxHp;
        int totalCritical = character.Critical;

        foreach (var stat in character.equippedItems)
        {
            Item equippedItem = stat.Value;
            switch (equippedItem.StatType)
            {
                case StatType.Attack:
                    totalAtk += equippedItem.StatValue;
                    break;
                case StatType.Defense:
                    totalDef += equippedItem.StatValue;
                    break;
                case StatType.Health:
                    totalMaxHp += equippedItem.StatValue;
                    break;
                case StatType.Critical:
                    totalCritical += equippedItem.StatValue;
                    break;

            }
        }
        atkValue.text = $" 공격력 \n {totalAtk}";
        defValue.text = $" 방어력 \n {totalDef}";
        hpValue.text = $" 체력\n {totalMaxHp}";
        criticalValue.text = $" 치명타 \n {totalCritical}";
    }
}
