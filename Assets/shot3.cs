using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot3 : MonoBehaviour
{
    public ShotGenarator shotGen;
    public static float ultbom = 0;
    float ultDestroy;
    
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
            ultbom++;
        }
    }
}
