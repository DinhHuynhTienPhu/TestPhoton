using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DropDownPoint : MonoBehaviour
{
    public GameObject pointPrefab;
    public float minX,maxX;
    void Start()
    {
        if(PhotonNetwork.IsMasterClient)
            StartCoroutine(DropPoint());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DropPoint(){
        while(true){
            yield return new WaitForSeconds(1);
            PhotonNetwork.Instantiate(pointPrefab.name, new Vector3(Random.Range(minX,maxX),10,0), Quaternion.identity);

        }
    }
}
