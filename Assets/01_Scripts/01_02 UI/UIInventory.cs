using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [Header("인벤토리")]
    [SerializeField] private ItemSlot slotPrefab;
    [SerializeField] private Transform slotParent;
    [SerializeField] private TextMeshProUGUI itemCountTxt;
    private int maxSlotCount = 30;
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
            newSlot.SetItem(inventory[i]); //생성한 슬롯에 현재 아이템을 추가하기 위해 데이터를 할당해주는 메서드를 호출
            newSlot.gameObject.SetActive(true); //슬롯을 활성화
            slotsList.Add(newSlot); //리스트에 활성화된 슬롯을 추가
        }
        UpdateItemCountTxt(slotsList.Count); //슬롯의 총 개수를 표시하는 텍스트에도 업데이트
    }
    public void ShowEquipPopUp(Item item)
    {
        if (uIPopup != null)
        {
            uIPopup.ShowPopup(item);
        }
    }
    public void UpdateUI()  // 슬롯을 업데이트 해주는 메서드
    {
        foreach(var slot in slotsList)
        {
            slot.UpdateSlot();
        }
    }
    public void UpdateItemCountTxt(int currentItemCount)  
    {
        itemCountTxt.text = currentItemCount.ToString() + " / " + maxSlotCount.ToString();
    }
}
