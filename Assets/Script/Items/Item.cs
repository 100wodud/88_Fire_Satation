using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Sprite SpeedUp;

    public static Object instance;
    public SpriteRenderer Render;

    public int Type = 0;
    public void DestroyAfterTime()
    {
        //3�� �� ������Ʈ ����
        Invoke("DestroyObject", 3f);
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        int effect = Random.Range(0, 10);
        if (effect > 5)
        {
            float x = Random.Range(-2.5f, 2.5f);
            float y = -4.3f;
            transform.position = new Vector3(x, y, 0f);
            Render.sprite = SpeedUp;
            Type = 0;
        }
        else if(effect <= 5)
        {
            DestroyObject();
        }
        DestroyAfterTime();
    }

    private void SpeedUpItem()
    {
        //�������� �۵��Ѵ�
        GameObject playerObject = GameObject.Find("Player");
        Movement _movement = playerObject.GetComponent<Movement>();
        _movement.speed += (int)1f;

        DestroyObject();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //�����۰� ���˽� �Ʒ� �Լ� ����
            SpeedUpItem();
        }
    }
}
