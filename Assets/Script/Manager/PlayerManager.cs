using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject waterFront;
    public static PlayerManager I;
    private RectTransform rect;
    public float water = 0;
    public int gauge = 0;

    void Awake()
    {
        I = this;
    }
    void Start()
    {

        rect = waterFront.GetComponent<RectTransform>();
    }
    void Update()
    {
        if(GameManager.I.GameLevel == 0)
        {
            if(gauge >= 5)
            {
                SceneManager.LoadScene("VictoryScene");
            }
        }else if (GameManager.I.GameLevel == 1)
        {
            if(gauge >= 10)
            {
                SceneManager.LoadScene("VictoryScene");
            }
        }
    }
    public void waterGauge() //물 게이지 추가
    {
        if (water < 6)
        {
            water += 0.5f;
        }
        else if(water == 6)
        {
            water = 0;
            gauge += 1;
        }
        rect.sizeDelta = new Vector2(water, rect.sizeDelta.y);
    }
    public void waterMinus() //물 게이지 마이너스
    {
        if (water > 0)
        {
            water -= 0.5f;
        }
        else if( water == 0)
        {
            water = 0; 
        }
        rect.sizeDelta = new Vector2(water, rect.sizeDelta.y);
    }
}
