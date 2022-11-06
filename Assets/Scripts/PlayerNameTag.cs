using UnityEngine;
using Photon.Pun;
using TMPro;


public class PlayerNameTag : MonoBehaviourPun

{
    [SerializeField] private TextMeshProUGUI nameText;

    // Start is called before the first frame update
    private void Start()
    {
        if (photonView.IsMine) { return; }

        SetName();
    }

    //private void SetName() => nameText.text = PhotonView.Owner.NickName;
    //private void SetName() => nameText.text = photonView.Owner.NickName;

    private void SetName()
    {
        nameText.text = photonView.Owner.NickName;
    }
    
}
