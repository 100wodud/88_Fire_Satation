using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public SpriteRenderer Render;
    public static Object instance;

    private Rigidbody2D ObjectRigid;

    public int Type = 0;

    // Start is called before the first frame update
    void Start()
    {


        //Type=0 �� �� object ũ�� ����
        float size = Random.Range(0.5f, 1.0f);
        transform.localScale = new Vector3(size, size, 1);

        //x�� -3~3 ���� ���� ��ġ ����
        float x = Random.Range(-3.0f, 3.0f);
        transform.position = new Vector3(x, 5.0f, 0);

        //object �ӵ� ����
        ObjectRigid = GetComponent<Rigidbody2D>();
        float speed = Random.Range(0.5f, 4.0f);
        ObjectRigid.drag = speed;

        //object ���� ���� �� Ÿ�� ����
        int color = Random.Range(0, 101);
        if (color <= 10)
        {
            Render.color = new Color(0.5f, 0.5f, 0.5f, 1f);
            Type = 1;
            transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {    
        //�÷��̾�� ������ �޼���
        if (collision.gameObject.tag == "Player")
        {
            if(Type == 0) Destroy(gameObject);
        }

        // ���� ������ ������ ���, ����
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }

}
