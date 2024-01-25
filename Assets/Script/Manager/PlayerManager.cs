using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject waterFront;
    public static PlayerManager I;
    float water = 0;
    void Awake()
    {
        I = this;
    }
    void Start()
    {
        
    }
    void Update()
    {

    }
    public void waterGauge() //물 게이지 추가
    {
        if (water < 7)
        {
            water += 0.5f;
            waterFront.transform.localScale = new Vector3(water, 1.0f, 1.0f);
        }
        else { water = 0; }

    }
    public void waterMinus() //물 게이지 마이너스
    {
        if (water > 0)
        {
            water -= 0.5f;
            waterFront.transform.localScale = new Vector3(water, 1.0f, 1.0f);
        }
        else { water = 0; }

    }
}
