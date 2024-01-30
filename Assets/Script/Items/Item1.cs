using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    public Sprite SpeedDown;

    public static Object instance1;
    public SpriteRenderer Render1;

    public int Type = 1;
    public void DestroyAfterTime()
    {
        //3�� �ڿ� ������Ʈ ����
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
        if (effect <= 5)
        {
            float x = Random.Range(-2.5f, 2.5f);
            float y = -4.3f;
            transform.position = new Vector3(x, y, 0f);
            Render1.sprite = SpeedDown;
            Type = 1;
        }
        DestroyAfterTime();
    }

    private void SpeedDownItem()
    {
        //�������� �۵��Ѵ�
        GameObject playerObject = GameObject.Find("Player");
        Movement _movement = playerObject.GetComponent<Movement>();
        _movement.speed -= (int)0.8f;

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
            SpeedDownItem();
        }
    }
}
