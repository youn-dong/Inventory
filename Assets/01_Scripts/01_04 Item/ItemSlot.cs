using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [Header("Slot")]
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI quantityText; //인벤토리에 있는 아이템의 개수
    [SerializeField] private TextMeshProUGUI equipTxt;
    [SerializeField] private Button itemBtn;

    private int curQuantity;

    private Item currentItem;

    private void Start()
    {
        itemBtn.onClick.AddListener(OnItemClicked);
    }
    public void SetItem(Item newItem, int quantity = 1)
    {
        currentItem = newItem; //새로운 아이템을 할당
        curQuantity = quantity;
        UpdateSlot();
    }
    public void ClearSlot() //아이템이 저장되어 있지 않은 슬롯을 삭제시켜주는 메서드
    {
        currentItem = null;
        icon.sprite = null;
        icon.enabled = false;
        quantityText.text = ""; 
    }
    public void UpdateSlot() 
    {
        UIInventory uiInventroy = UIManager.Instance.Inventory;
        if (currentItem != null)  //갖고있는 아이템이라면
        {
            icon.sprite = currentItem.Image;
            icon.enabled = true;  // 갖고있는 아이템 이미지 활성화
            quantityText.text = curQuantity > 1 ? curQuantity.ToString() : ""; //삼항연산자를 활용하여 갖고있는 아이템이 1보다 크다면 개수를 표시
                                                                               //추후 소비아이템을 확장할 때 소비아이템의 개수를 표시하기 위한 방법

            bool isEquipped = GameManager.Instance.Player.IsItemEquipped(currentItem); //아이템을 장착했는지 여부를 확인하고,
            if (isEquipped)
            {
                Debug.Log("현재상태" + isEquipped);
                equipTxt.gameObject.SetActive(isEquipped);
            }
            else
            {
                Debug.Log("현재상태" + isEquipped);
                equipTxt.gameObject.SetActive(false);
            }
        }
        else
        {
            icon.enabled = false; //갖고있지 않기 때문에 비활성화
            quantityText.text = "";
            equipTxt.gameObject.SetActive(false);
        }
    }
    public void OnItemClicked()
    {
        UIManager.Instance.Inventory.ShowEquipPopUp(currentItem);
    }
}
