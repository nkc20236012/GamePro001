using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bom : MonoBehaviour
{
    float bomTime;
    void Start()
    {

    }

    void Update()
    {
        bomTime += Time.deltaTime;

        if(bomTime > 1f)
        {
            Destroy(gameObject);
        }
    }
}
