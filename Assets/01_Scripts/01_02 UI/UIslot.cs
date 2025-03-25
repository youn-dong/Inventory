using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIslot : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI quantityText; //인벤토리에 있는 아이템의 개수

    private Item item;
    private int curQuantity;

    public void SetItem(Item newItem, int quantity = 1)
    {
        item = newItem; //새로운 아이템을 할당
        curQuantity = quantity;
        UpdateSlot();
    }

    public void UpdateSlot()
    {
        if (item != null)  //갖고있는 아이템이라면
        {
            icon.sprite = item.Image;
            icon.enabled = true;  // 갖고있는 아이템 이미지 활성화
            quantityText.text = curQuantity > 1 ? curQuantity.ToString() : ""; //삼항연산자를 활용하여 갖고있는 아이템이 1보다 크다면 개수를 표시
        }
        else
        {
            icon.enabled = false; //갖고있지 않기 때문에 비활성화
            quantityText.text = "";
        }
    }
}
