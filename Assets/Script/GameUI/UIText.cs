using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    public Text Count;
    public Text Mode;
    public Text Time;
    string n = "5";
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (Mode != null)
        {
            if (GameManager.I.GameLevel == 0)
            {
                Mode.text = "Easy Mode";
                n = "5";
            }
            else if (GameManager.I.GameLevel == 1)
            {
                Mode.text = "Normal Mode";
                n = "10";
            }
            else
            {
                Mode.text = "Hard Mode";
                n = "¡Ä";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        count = PlayerManager.I.gauge;
        if (Count != null) Count.text = count.ToString() + " / " + n;
        if (Time != null) Time.text = GameManager.I.time.ToString("N2");

        
    }
}
