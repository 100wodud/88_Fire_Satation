using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject Object;
    public static float AddSpeed = 0f;
    int timeLevel = 0;
    AudioSource audioSoure;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeObject", 0.15f, 1f);

    }

    void MakeObject()
    {
        Instantiate(Object);
    }

    // Update is called once per frame
    void Update()
    {
        // 20초 마다 효과음
        if ((int)(GameManager.I.time / 10) > timeLevel & GameManager.I.GameLevel == 2)
        {
            timeLevel = (int)(GameManager.I.time / 10);
            audioSoure = GetComponent<AudioSource>();
            audioSoure.Play();
            Debug.Log(timeLevel);
        }

    }
}
