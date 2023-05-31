using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameDirector : MonoBehaviour
{
    GameObject en;
    float time = 100.0f;
    float a = 0;
    GameObject Km;
    [SerializeField]
    float Cnt;

    void Start()
    {
        Application.targetFrameRate = 60;

        Km = GameObject.Find("km");
        en = GameObject.Find("Time");

    }
    public void damage()
    {
        en.GetComponent<Image>().fillAmount -= 0.1f;
        time -= 10f;

    }


    void Update()
    {

        a += 1;
        //Debug.Log(a);
        Km.GetComponent<Text>().text = a.ToString("00000000") + "km";

        time -= Time.deltaTime;
        en.GetComponent<Image>().fillAmount -= 1.0f / Cnt * Time.deltaTime;
        //Debug.Log(time);
        if(time < 0)
        {
            SceneManager.LoadScene("TitlScene");
        }
       // Debug.Log(time);

        //if(time == 0)
        //{
        //    SceneManager.LoadScene()
        //}
    }
}
