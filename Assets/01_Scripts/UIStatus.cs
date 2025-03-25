using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
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
        
    }
}
