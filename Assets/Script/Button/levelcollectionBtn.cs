using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcollectionBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScene(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }
    public void ChangeGameLevel(int gmae_level)
    {
        GameManager.I.GameLevelChange(gmae_level);
    }
}
