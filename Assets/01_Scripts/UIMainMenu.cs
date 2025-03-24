using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("캐릭터 정보")]
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI levelTxt;
    public TextMeshProUGUI goldAmount;

    [Header("버튼")]
    public Button inventoryBtn;
    public Button statusBtn;
    // Start is called before the first frame update
    void Start()
    {
        inventoryBtn.onClick.AddListener(OpenInventory);
        statusBtn.onClick.AddListener(OpenStatus);
    }

    // Update is called once per frame
    void Update()
    {
        
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
}

