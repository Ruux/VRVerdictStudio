using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon;
using Photon.Pun;
using TMPro;

public class PlayerColor : MonoBehaviourPun
{
    //[SerializeField]
    //private GameObject player;
    private Renderer playerRenderer;
    private Color newPlayerColor;
    private float randomOne, randomTwo, randomThree;

    // Start is called before the first frame update
    void Start()
    {
        SetColor();
        if (photonView.IsMine) { return; }

        SetColor();
        playerRenderer = GetComponent<Renderer>();
        //gameObject.GetComponent<Button>().onClick.AddListener(ChangePlayerColor);
        
    }

    void SetColor()
    {
        playerRenderer.material.color = Color.red;

    }

    private void ChangePlayerColor()
    {
        randomOne = Random.Range(0f, 1f);
        randomOne = Random.Range(0f, 1f);
        randomOne = Random.Range(0f, 1f);

        newPlayerColor = new Color(randomOne, randomTwo, randomThree, 1f);

        playerRenderer.material.SetColor("_Color", newPlayerColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
