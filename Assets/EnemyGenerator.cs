
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float delta = 0;
    float span = 0;
    float span2 = 0;
    float d;
    float r;
    float c;
    float y;
    public GameObject strongPre;
    void Start()
    {

    }

    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            span = 0;
            c = Random.Range(0.2f,0.8f);
            y = Random.Range(4.5f, -4.5f);
            span = c;
            delta = 0;
            GameObject go = Instantiate(EnemyPrefab);

            go.transform.position = new Vector3(12, y, 0);
        }
        //if (delta > span2)
        //{
        //    span2 = 0;
        //    d = Random.Range(0.5f, 1f);
        //    r = Random.Range(4.5f, -4.5f);
        //    span2 = d;
        //    delta = 0;
        //    GameObject go = Instantiate(strongPre);

        //    go.transform.position = new Vector3(12, r, 0);
        //}

    }
}
