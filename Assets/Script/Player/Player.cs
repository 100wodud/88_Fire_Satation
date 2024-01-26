using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {

        
        
        //물 닿으면 게이지 상승
        if (coll.gameObject.tag == "Water")
        {
            
            PlayerManager.I.waterGauge();
        }
        //기름 닿으면 게이지 하락
        else if (coll.gameObject.tag == "Oil")
        {
            PlayerManager.I.waterMinus();
            Debug.Log("기름만남");
        }
    }
}
