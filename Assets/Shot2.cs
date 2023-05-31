using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot2 : MonoBehaviour
{
    float tagcnt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0.1f, 0);

        if (transform.position.x > 11.5f)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyTag")
        {
            tagcnt += 1;
        }
        if(tagcnt ==2)
        {
            Destroy(gameObject);
            tagcnt = 0;
        }
    }

}

