using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] public float minX = -4;
    //[SerializeField] public float maxX = 4;
    //[SerializeField] public float minY = -10;
    //[SerializeField] public float maxY = 10;

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




            //var pos = transform.position;
            //pos.x = Mathf.Clamp(pos.x, minX, maxX);
            //pos.y = Mathf.Clamp(pos.y, minY, maxY);

            //transform.position = pos;









        }

    }
