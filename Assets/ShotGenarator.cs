using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGenarator : MonoBehaviour
{
    GameObject player;
    GameObject ultposition;
    public GameObject ShotPrefab;
    public GameObject Shot2Pre;
    public GameObject hisatuPre;
    public GameObject hisatu9Pre;
    bool buttonPressed = false;
    float timer = 0f;
    float interval = 0.5f;
    public float chargeTime =2f;
    public EnemyController enemyController;
    public shot3 ShotUlt;
    float ultckeck;
    int Killcnt;
     float ultTime = 0f;
    float delta;
    float span = 0.5f;
    float c;

    void Start()
    {
        player = GameObject.Find("Player");
        ultposition = GameObject.Find("hisatuPre");
        

    }


    void Update()
    {
        Killcnt = EnemyController.enemycnt;
        ultckeck = shot3.ultbom;

        //Debug.Log(Killcnt);
        if(Input.GetButton("Fire1"))
        {
            buttonPressed = true;


        }
        if(Input.GetButton("Fire2"))
        {
            chargeTime -= Time.deltaTime;
            Debug.Log(chargeTime);
            
        }
        if(Input.GetButtonUp("Fire2"))
        {
            if(chargeTime < 0)
            {
                GameObject charge = Instantiate(Shot2Pre);
                charge.transform.position = player.transform.position;
                chargeTime = 1.5f;
            }
            else
            {
                chargeTime = 1.5f;
            }

        }
        if (Killcnt >= 15)
        {
        if (Input.GetButton("Fire3"))
          {
                
             GameObject ult = Instantiate(hisatuPre);
             ult.transform.position = player.transform.position;
              

              EnemyController.enemycnt = 0;
           }
        }
        if (ultckeck > 0.5f)
        {
                GameObject bom = Instantiate(hisatu9Pre);
                float py = Random.Range(-4, 4);
            float px = Random.Range(0, 11);
                bom.transform.position = new Vector2(px, py);
            ultTime += Time.deltaTime;
            if(ultTime >0.5f)
            {
                shot3.ultbom = 0;
            }
            
            

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
