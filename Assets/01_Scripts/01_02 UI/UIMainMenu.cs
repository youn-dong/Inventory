using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface IGetData
{
    void SetCharacterData(Character character);
}
public class UIMainMenu : MonoBehaviour, IGetData
{
    [Header("캐릭터 정보")]
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI levelTxt;
    public TextMeshProUGUI goldAmount;
    public TextMeshProUGUI expTxt;
    public TextMeshProUGUI desTxt;
    
    [Header("Element")]
    public Button inventoryBtn;
    public Button statusBtn;
    public Slider expSlider;
    void Start()
    {
        inventoryBtn.onClick.AddListener(OpenInventory);
        statusBtn.onClick.AddListener(OpenStatus);
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(true);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(false);
    }
    public void OpenStatus()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
        UIManager.Instance.Status.gameObject.SetActive(true);
    }
    public void OpenInventory()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(true);
        UIManager.Instance.Status.gameObject.SetActive(false);
    }
    public void SetCharacterData(Character character)
    {
        nameTxt.text = $"ID : {character.UserName} ";
        levelTxt.text = $"Level : {character.Level} ";
        goldAmount.text = $"{character.Gold} ";
        expTxt.text = $"{character.CurExp} / {character.MaxExp}";
        expSlider.value = (float)character.CurExp / character.MaxExp;
        desTxt.text = character.Description;
    }
}

