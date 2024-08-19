using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nicknameText;

    public void SetNickname(string nickname)
    {
        nicknameText.text = nickname;
    }
}
