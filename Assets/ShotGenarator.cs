using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGenarator : MonoBehaviour
{
    GameObject player;
    public GameObject ShotPrefab;
    bool buttonPressed = false;
    float timer = 0f;
    float interval = 0.5f;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        if(Input.GetButton("Jump"))
        {
            buttonPressed = true;
            //GameObject go = Instantiate(ShotPrefab);
            //go.transform.position = player.transform.position;

        }
    }
    private void FixedUpdate()
    {
        timer += Time.fixedDeltaTime;
        if(timer >= interval)
        {
            timer = 0f;

            if(buttonPressed)
            {
                GameObject go = Instantiate(ShotPrefab);
                go.transform.position = player.transform.position;

            }
            buttonPressed = false;
        }
    }
}
