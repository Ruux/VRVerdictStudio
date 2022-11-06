using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class Keyboard : MonoBehaviourPunCallbacks

{
    NetworkManager networkManager;
    [SerializeField] GameObject NetworkManager;

    //public TMP_InputField inputField;
    public GameObject normalButtons;
    public GameObject capsButtons;
    public GameObject connectButton;
    public GameObject connectingStatus;
    public GameObject connectOptions;

    private bool caps;
    private bool connect;
    private bool shift;
    private bool color;
    private Color playerColor;

    //float time;
    //float timeDelay;

    [SerializeField] GameObject player;
    private Renderer playerRenderer;
    private Color newPlayerColor;
    private float randomOne, randomTwo, randomThree;

    //[SerializeField] private GameObject connectStatus = null;
    [SerializeField] private TMP_InputField inputField = null;
    //[SerializeField] private Button continueButton = null;

    private bool isConnected = false;

    private const string PlayerPrefsNameKey = "PlayerName";

    // Start is called before the first frame update
    void Start()
    {
        networkManager = NetworkManager.GetComponent<NetworkManager>();
        //SetupInputField();
        caps = false;
        connect = false;
        normalButtons.SetActive(true);
        capsButtons.SetActive(false);
        shift = false;
        color = false;

        playerRenderer = player.GetComponent<Renderer>();
    }

    /*private void SetupInputField()
    {
        if (!PlayerPrefs.HasKey(PlayerPrefsNameKey)) { return; }

        string defaultName = PlayerPrefs.GetString(PlayerPrefsNameKey);

        inputField.text = defaultName;

        SetPlayerName(defaultName);

    }

    public void SetPlayerName(string name)
    {
        if (!string.IsNullOrEmpty(name)) 
        {
            connectButton.SetActive(true);
        }
    }

    public void SavePlayerName()
    {
        string playerName = inputField.text;

        //PhotonNetwork.LocalPlayer.NickName = playerName;
        PhotonNetwork.NickName = playerName;

        PlayerPrefs.SetString(PlayerPrefsNameKey, playerName);
    }*/

    /*private void Update()
    {
        time = time + 1f * Time.deltaTime;

        if (connect == true & time >= timeDelay)
        {
            Debug.Log("Connection Established!");
            connectOptions.SetActive(true);
        }
    }*/

    public void InsertChar(string c)
    {
        inputField.text += c;
        if (shift)
        {
            capsButtons.SetActive(false);
            normalButtons.SetActive(true);
            shift = false;
        }
    }

    public void DeleteChar()
    {
        if (inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
    }

    public void ClearChars()
    {
        if (inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, 0);
        }
    }

    public void InsertSpace()
    {
        inputField.text += " ";
    }

    public void CapsPressed()
    {
        if (!caps)
        {
            normalButtons.SetActive(false);
            capsButtons.SetActive(true);
            caps = true;
        } else
        {
            capsButtons.SetActive(false);
            normalButtons.SetActive(true);
            caps = false;
        }
    }

    public void ShiftPressed()
    {
        if (!shift)
        {
            normalButtons.SetActive(false);
            capsButtons.SetActive(true);
            shift = true;
        }
        else
        {
            capsButtons.SetActive(false);
            normalButtons.SetActive(true);
            shift = false;
        }
    }

    public void ColorPressed()
    {

        
        /*randomOne = Random.Range(0f, 1f);
        randomOne = Random.Range(0f, 1f);
        randomOne = Random.Range(0f, 1f);

        newPlayerColor = new Color(randomOne, randomTwo, randomThree, 1f);

        playerRenderer.material.SetColor("_Color", newPlayerColor);*/
    }

    public void ConnectPressed()
    {
        //Debug.Log("Connect Pressed!");
        connectButton.SetActive(false);
        connectingStatus.SetActive(false);
        connectOptions.SetActive(true);
    }

    public void Connecting()
    {

        /*if(!isConnected)
        {
            connectButton.SetActive(false);
            connectingStatus.SetActive(true);
        }else
        {
            connectButton.SetActive(false);
            connectingStatus.SetActive(false);
            connectOptions.SetActive(true);
        }*/

    }

    public void ConnectNo()
    {
        connectButton.SetActive(true);
        connectOptions.SetActive(false);
    }

}
