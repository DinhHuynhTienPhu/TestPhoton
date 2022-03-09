using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnerCharacter : MonoBehaviour
{
    public GameObject playerPrefab;

    void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(Random.Range(-3,3), 0, 0), Quaternion.identity, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
