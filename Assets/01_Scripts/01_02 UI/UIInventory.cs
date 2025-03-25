using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UIslot slotPrefab;
    [SerializeField] private Transform slotParent;
    private List<UIslot > slots = new List<UIslot>();

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
            slots.Add(newSlot);
        }
    }
}
