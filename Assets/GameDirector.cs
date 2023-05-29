using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameDirector : MonoBehaviour
{
    GameObject en;
    float time = 100.0f;
    Text Km;
    GameObject score;
    [SerializeField]
    float Cnt;

    void Start()
    {
        score = GameObject.Find("km");
        Km = GetComponent<Text>();
        en = GameObject.Find("Time");

    }
    public void damage()
    {
        en.GetComponent<Image>().fillAmount -= 0.1f;
        time -= 10f;

    }


    void Update()
    {
        time -= Time.deltaTime;
        en.GetComponent<Image>().fillAmount -= 1.0f / Cnt * Time.deltaTime;
        Debug.Log(time);
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
