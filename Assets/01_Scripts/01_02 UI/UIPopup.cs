using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopup : MonoBehaviour
{
    [Header("Selected Item")]
    public TextMeshProUGUI selectedItemName;
    public TextMeshProUGUI selectedItemDescription;
    public TextMeshProUGUI selectedItemStatName;
    public TextMeshProUGUI selectedItemStatValue;

    [Header("Popup")]
    public GameObject EquipPanel;
    public Button equipBtn;
    public Button unEquipBtn;
    public Button returnBtn;

    private Item currentItem;
    private void Start()
    {
        equipBtn.onClick.AddListener(OnEquipButton);
        unEquipBtn.onClick.AddListener(OnUnEquipButton);
        returnBtn.onClick.AddListener(ClosePopUp);
        EquipPanel.SetActive(false);
    }
    public void ShowPopup(Item item)  //아이템 정보를 담은 팝업을 띄우기
    {
        currentItem = item; 
        if(currentItem == null)  //아이템이 현재 포함되어있지않다면 팝업창은 비활성화시키기
        {
            ClosePopUp();
            return;
        }
        selectedItemName.text = currentItem.ItemName;
        selectedItemStatName.text = currentItem.StatType.ToString();
        selectedItemStatValue.text = currentItem.StatValue.ToString();

        bool isEquipped = GameManager.Instance.Player.IsItemEquipped(currentItem); 
        equipBtn.gameObject.SetActive(!isEquipped); //장착버튼은 아이템을 장착하지 않았을 때 표시하기위해서 
        unEquipBtn.gameObject.SetActive(isEquipped); //장착해제버튼은 아이템을 장착했을 때 표시하기위해서
        returnBtn.gameObject.SetActive(true);

        EquipPanel.SetActive(true);
    }

    private void OnEquipButton()
    {
        if(currentItem != null)
        {
            GameManager.Instance.Player.EquipItem(currentItem);
        }
        ClosePopUp();
    }

    private void OnUnEquipButton()
    {
        if(currentItem != null)
        {
            GameManager.Instance.Player.UnEquipItem(currentItem);
        }
        ClosePopUp();
    }
    private void ClosePopUp()
    {
        EquipPanel.SetActive(false);
    }
}
