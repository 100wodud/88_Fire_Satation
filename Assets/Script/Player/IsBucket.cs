using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsBucket : MonoBehaviour
{
    public new SpriteRenderer renderer;
    public PlayerManager manager;
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(manager.water > 2)
        {
            renderer.enabled = true;
        }
        else
        {
            renderer.enabled = false;
        }
    }
}
