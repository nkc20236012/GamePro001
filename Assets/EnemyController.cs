using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static int enemycnt = 0;
    void Start()
    {
        

}

void Update()
    {
        transform.Translate(-0.03f, 0, 0);

        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().damage();
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Shot")
        {
            Destroy(gameObject);
            enemycnt++;
            Debug.Log(enemycnt);


        }
    }

}


