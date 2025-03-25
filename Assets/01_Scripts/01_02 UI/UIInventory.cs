using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UIslot slotPrefab;
    [SerializeField] private Transform slotParent;
    private List<UIslot > slotsList = new List<UIslot>();

    [Header("버튼")]
    public Button mainUIBtn;
    void Start()
    {
        mainUIBtn.onClick.AddListener(UIManager.Instance.MainMenu.OpenMainMenu);
        InitInventoryUI(); //Start에서 실행하면서 초기화
    }

    public void InitInventoryUI()
    {
        int allSlots = 30;
        for(int i = 0; i < allSlots; i++)
        {
            UIslot newSlot = Instantiate(slotPrefab, slotParent); //새로운 슬롯을 만들어서 slotParent에 넣고 리스트에 추가
            slotsList.Add(newSlot);
        }
    }
    public void SetItemData(List<Item> inventory) // 인벤토리에 저장된 데이터를 UI로 반영하기 위해서
    {
        for(int i=0; i<inventory.Count; i++) // 데이터가 인벤토리의 총 갯수보다 작아질 때까지
        {
            if(i<inventory.Count)
            {
                slotsList[i].SetItem(inventory[i]); //UI에 데이터를 추가해주고
            }
            else //초과했다면
            {
                //삭제를 해줘야함.
                slotsList[i].ClearSlot();
            }
        }
    }
}
