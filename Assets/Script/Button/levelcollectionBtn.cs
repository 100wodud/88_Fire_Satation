using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcollectionBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeGameLevel(int gmae_level)
    {
        GameManager.I.GameLevelChange(gmae_level);
        SceneManager.LoadScene("GameScene");
    }
}
