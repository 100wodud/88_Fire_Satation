using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Sprite SpeedUp;
    public Sprite EX;
    
    public static Object instance;
    public SpriteRenderer Render;

    public int Type = 0;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.5f, 2.5f);
        float y = -4.3f;
        transform.position = new Vector3(x, y, 0f);
        Render.sprite = SpeedUp;
        Type = 0;

        int effect = Random.Range(0, 11);
        if (effect <= 4)
        {
            Render.sprite = EX;
            Type = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
