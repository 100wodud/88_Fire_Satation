using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject waterFront;
    public static PlayerManager I;
    private RectTransform rect;
    float water = 0;
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

    }
    public void waterGauge() //�� ������ �߰�
    {
        if (water < 6)
        {
            water += 0.5f;
        }
        else if(water == 6)
        {
            water = 0; 
        }
        rect.sizeDelta = new Vector2(water, rect.sizeDelta.y);
    }
    public void waterMinus() //�� ������ ���̳ʽ�
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

    public void GameLevelChange(int game_level)
    {
        if (game_level == 0) // easy �϶�
        {
            if (water == 5) 
            {
                SceneManager.LoadScene("VictoryScene");
            }
        }
        else if (game_level == 1) // normal �϶�
        {
            if (water == 10)
            {
                SceneManager.LoadScene("VictoryScene");
            }
        }
    }
}
