using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private ItemSlot slotPrefab;
    [SerializeField] private Transform slotParent;
    private List<ItemSlot> slotsList = new List<ItemSlot>();

    [Header("버튼")]
    public Button mainUIBtn;

    public UIPopup uIPopup;

    void Start()
    {
        mainUIBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
    }
    public void SetItemData(List<Item> inventory) // 인벤토리에 저장된 데이터를 UI로 반영하기 위해서
    {
        foreach(Transform slot in slotParent) //일단 인벤토리 내 슬롯을 모두 삭제
        {
            Destroy(slot.gameObject);
        }
        slotsList.Clear(); //내가 갖고 있는 아이템만큼 슬롯을 만들기 위해 정리

        for(int i=0; i<inventory.Count; i++) // 갖고있는 아이템의 숫자에 따라
        {
            ItemSlot newSlot = Instantiate(slotPrefab, slotParent); //슬롯을 재생성
            newSlot.SetItem(inventory[i]); //
            newSlot.gameObject.SetActive(true);
            slotsList.Add(newSlot);
        }
    }
    public void ShowEquipPopUp(Item item)
    {
        if(uIPopup != null)
        {
            uIPopup.ShowPopup(item);
        }
    }
}
