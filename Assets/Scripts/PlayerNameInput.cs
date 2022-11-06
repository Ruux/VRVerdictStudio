using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameInput : MonoBehaviour
{

    [SerializeField] private TMP_InputField nameInputField = null;
    //[SerializeField] private Button continueButton = null;
    [SerializeField] private ButtonVR connectButton = null;

    private const string PlayerPrefsNameKey = "PlayerName";

    // Start is called before the first frame update
    private void Start() => SetupInputField();

    private void SetupInputField()
    {
        if(!PlayerPrefs.HasKey(PlayerPrefsNameKey)) { return; }

        string defaultName = PlayerPrefs.GetString(PlayerPrefsNameKey);

        nameInputField.text = defaultName;

        SetPlayerName(defaultName);

    }

    public void SetPlayerName(string name)
    {
        connectButton.enabled = !string.IsNullOrEmpty(name);
    }

    public void SavePlayerName()
    {
        string playerName = nameInputField.text;

        PhotonNetwork.NickName = playerName;

        PlayerPrefs.SetString(PlayerPrefsNameKey, playerName);
    }

    /* Update is called once per frame
    void Update()
    {
        
    }*/
}
