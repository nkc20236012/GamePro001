using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot3 : MonoBehaviour
{
    GameObject boom;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0.1f, 0, 0);

        if (transform.position.x > 11.5f)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="EnemyTag")
        {
            Destroy(gameObject);
          boom.GetComponent<ShotGenarator>().Hisatu();
        }
    }
}
