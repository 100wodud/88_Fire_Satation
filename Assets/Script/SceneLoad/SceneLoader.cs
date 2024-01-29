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
    //씬두개 불러오기
    void LoadScene()
    {
        SceneManager.LoadScene("CharacterScene", LoadSceneMode.Additive);
        SceneManager.LoadScene("ObjectScene",LoadSceneMode.Additive);
        SceneManager.LoadScene("FireScene", LoadSceneMode.Additive);
        GameManager.I.StartTimer();
    }
}
