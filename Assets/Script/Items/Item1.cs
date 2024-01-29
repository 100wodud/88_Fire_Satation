using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    public Sprite SpeedUp;
    public Sprite SpeedDown;

    public static Object instance;
    public SpriteRenderer Render;

    public int Type = 0;
    public void DestroyAfterTime()
    {
        Invoke("DestroyObject", 3f);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.5f, 2.5f);
        float y = -4.3f;
        transform.position = new Vector3(x, y, 0f);
        Render.sprite = SpeedUp;
        Type = 0;

        int effect = Random.Range(0, 11);
        if (effect <= 1)
        {
            Render.sprite = SpeedDown;
            Type = 1;
        }
        DestroyAfterTime();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
