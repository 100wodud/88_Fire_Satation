using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text bestScore;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = GameManager.I.time.ToString("N2");
        if(GameManager.I.GameLevel == 0)
        {
            bestScore.text = GameManager.I.EasyTime.ToString("N2");
        } else if(GameManager.I.GameLevel == 1)
        {
            bestScore.text = GameManager.I.NormalTime.ToString("N2");
        }
        else if(GameManager.I.GameLevel == 2)
        {
            bestScore.text = GameManager.I.HardTime.ToString("N2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
