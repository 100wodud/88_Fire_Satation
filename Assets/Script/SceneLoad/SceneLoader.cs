using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        LoadScene();
       
    }
    //���ΰ� �ҷ�����
    void LoadScene()
    {
        SceneManager.LoadScene("CharacterScene", LoadSceneMode.Additive);
        SceneManager.LoadScene("ObjectScene",LoadSceneMode.Additive);
        SceneManager.LoadScene("FireScene", LoadSceneMode.Additive);
        GameManager.I.StartTimer();
    }
}
