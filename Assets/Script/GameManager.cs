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
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("StartScene", LoadSceneMode.Additive);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameLevelChange(int game_level)
    {
        GameLevel = game_level;
    }
}
