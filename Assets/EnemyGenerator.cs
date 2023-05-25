
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    float delta = 0;
    float span = 0;
    float c;
    float y;
    void Start()
    {

    }

    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            span = 0;
            c = Random.Range(0.1f,0.5f);
            y = Random.Range(4.5f, -4.5f);
            span = c;
            delta = 0;
            GameObject go = Instantiate(EnemyPrefab);
            go.transform.position = new Vector3(12,y,0);
        }
    }
}
