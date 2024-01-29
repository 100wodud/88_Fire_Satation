using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager I;

    void Awake()
    {
        if (I != null) //�̹� �����ϸ�
        {
            Destroy(gameObject); //�ΰ� �̻��̴� ����
            return;
        }
        I = this; //�ڽ��� �ν��Ͻ���
        DontDestroyOnLoad(gameObject); //�� �̵��ص� ��������ʰ�
    }

    //���� ���̵� 0 - Easy / 1 - Normal / 2 - Hard
    public int GameLevel = 1;

    // global time
    public float time = 0;
    public bool timerSet = false;
    public float EasyTime = 0;
    public float NormalTime = 0;
    public float HardTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("StartScene");

    }

    // Update is called once per frame
    void Update()
    {
        if (timerSet)
        {
            time += Time.deltaTime;
            Debug.Log(time);
        }
        
    }

    public void GameLevelChange(int game_level)
    {
        GameLevel = game_level;
    }

    public void StartTimer()
    {
        time = 0;
        timerSet = true;
    }

    public void StopTimer() 
    { 
        timerSet = false;
        if(EasyTime < time && GameLevel == 0)
        {
            EasyTime = time;
        } else if(NormalTime < time && GameLevel == 1)
        {
            NormalTime = time;
        } else if(HardTime < time && GameLevel == 2)
        {
            HardTime = time;
        }
    }
}