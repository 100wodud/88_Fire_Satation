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

        
        
        //�� ������ ������ ���
        if (coll.gameObject.tag == "Water")
        {
            
            PlayerManager.I.waterGauge();
        }
        //�⸧ ������ ������ �϶�
        else if (coll.gameObject.tag == "Oil")
        {
            PlayerManager.I.waterMinus();
            Debug.Log("�⸧����");
        }
    }
}
