using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("ROOM", new RoomOptions { MaxPlayers = 2 },TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Ball", new Vector3(Random.Range(-9, 9),transform.position.y,-0.27f),Quaternion.identity);
    }
}
