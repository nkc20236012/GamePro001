using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGenarator : MonoBehaviour
{
    GameObject player;
    public GameObject ShotPrefab;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if(Input.GetButton("Jump"))
        {
            
            GameObject go = Instantiate(ShotPrefab);
            go.transform.position = player.transform.position;

        }
        Debug.Log(player.transform.position);
    }
}
