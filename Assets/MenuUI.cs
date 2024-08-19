using Elympics;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;

    private void Awake()
    {
        playButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        ElympicsLobbyClient.Instance.PlayOnlineInRegion("warsaw");
    }
}
