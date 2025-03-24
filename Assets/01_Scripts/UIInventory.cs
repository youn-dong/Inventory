using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{

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
}
