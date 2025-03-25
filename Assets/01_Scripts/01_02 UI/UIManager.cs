using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu mainMenu; //인스펙터에서 보이면서 프로퍼티로 갖고 있을 수 있
    [SerializeField] private UIInventory inventory; //Attribute를 사용하고 getter에 람다식으로 외부에 필드를 반환하는 형식으로
    [SerializeField] private UIStatus status;

    public UIMainMenu MainMenu => mainMenu;
    public UIStatus Status => status;
    public UIInventory Inventory => inventory;

    public static UIManager Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return; 
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
}
