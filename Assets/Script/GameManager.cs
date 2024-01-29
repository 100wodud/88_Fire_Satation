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
