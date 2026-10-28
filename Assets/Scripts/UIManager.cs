using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI _mapNameText;
    [SerializeField] private Button _resetButton;
    
    void Awake()
    {
        GameManager.Instance.OnMapLoaded += OnMapLoaded;
        _resetButton.onClick.AddListener(OnResetButtonClick);
    }

    void OnDestroy()
    {
        GameManager.Instance.OnMapLoaded -= OnMapLoaded;
        _resetButton.onClick.RemoveListener(OnResetButtonClick);
    }

    void OnMapLoaded(string mapName)
    {
        _mapNameText.text = mapName;
    }

    void OnResetButtonClick()
    {
        GameManager.Instance.ResetMap();
    }
}
