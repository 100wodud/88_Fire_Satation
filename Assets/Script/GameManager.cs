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
        if (I != null) //이미 존재하면
        {
            Destroy(gameObject); //두개 이상이니 삭제
            return;
        }
        I = this; //자신을 인스턴스로
        DontDestroyOnLoad(gameObject); //씬 이동해도 사라지지않게
    }

    //게임 난이도 0 - Easy / 1 - Normal / 2 - Hard
    public int GameLevel = 1;

    // global time
    public float time = 0;
    public bool timerSet = false;

    //난이도별 최고시간
    public float EasyTime = 0;
    public float NormalTime = 0;
    public float HardTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timerSet)
        {
            time += Time.deltaTime;
        }
        
    }

    // 게임 레벨 변경
    public void GameLevelChange(int game_level)
    {
        GameLevel = game_level;
    }

    // 게임 시작시 타이머 리셋 및 시작
    public void StartTimer()
    {
        time = 0;
        timerSet = true;
    }

    // 게임 타이머 종료 및 최고시간 저장
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

    // 싱글톤 패턴 사용
    #region singleton
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }
    #endregion

    public void GameOver()
    {
        SceneManager.LoadScene("DefeatScene");
    }
}
