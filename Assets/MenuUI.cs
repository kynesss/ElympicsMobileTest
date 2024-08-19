using Elympics;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button trainingButton;

    private void Awake()
    {
        playButton.onClick.AddListener(OnClick);
        trainingButton.onClick.AddListener(OnTrainingButtonClicked);
    }

    private void OnClick()
    {
        ElympicsLobbyClient.Instance.PlayOnlineInRegion("warsaw", null, null, "Default");
    }

    private void OnTrainingButtonClicked()
    {
        ElympicsLobbyClient.Instance.PlayOnlineInRegion("warsaw", null, null, "bots");
    }
}
