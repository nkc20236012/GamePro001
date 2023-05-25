using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator PlayerAnime;
    void Start()
    {
        PlayerAnime = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float speed = 0.1f;
        transform.position += new Vector3(x * speed, y * speed, 0);

        PlayerAnime.SetFloat("UP",y);


            

        



    }

}
