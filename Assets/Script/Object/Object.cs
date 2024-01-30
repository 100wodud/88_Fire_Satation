using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public SpriteRenderer Render;
    public Sprite Water;
    public Sprite Oil;

    public ParticleSystem particleObject;
    public static Object instance;
    private Rigidbody2D ObjectRigid;

    //object �⺻��
    public int Type = 0;
    float size = 0.3f;
    float x = 0;
    float speed = 1f;
    int timeLevel = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Type=0 �� �� object ũ�� ����
        size = Random.Range(0.15f, 0.3f);
        transform.localScale = new Vector3(size, size, 1);

        //x�� -3~3 ���� ���� ��ġ ����
        x = Random.Range(-3.0f, 3.0f);
        transform.position = new Vector3(x, 5.0f, 0);

        //object �ӵ� ����
        ObjectRigid = GetComponent<Rigidbody2D>();
        speed = Random.Range(1f, 4.0f) - ObjectSpawn.AddSpeed;
        ObjectRigid.drag = speed;
        Render.sprite = Water;

        // ���Ѹ�� 20�ʸ��� oil �� ����
        timeLevel = (int)(GameManager.I.time / 20);
        //object �̹��� ���� �� Ÿ�� ����
        int color = 99;
        if(GameManager.I.GameLevel == 1 )
        {
            color = Random.Range(0, 101);
        } else if (GameManager.I.GameLevel == 2 )
        {
            // �ð��� ���� ����
            int range = 101 - (timeLevel * 3);
            if(range < 20)
            {
                range = 20;
            }
            color = Random.Range(0, range);
        }

        if (color <= 1 & GameManager.I.GameLevel == 2)
        {
            Type = 2;
            transform.localScale = new Vector3(0.2f, 0.2f, 1);
            Render.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        } else if (color <= 10)
        {
            Render.sprite = Oil;
            Type = 1;
            transform.localScale = new Vector3(0.2f, 0.2f, 1);
            Render.color = new Color(1f, 1f, 1f, 1f);
            gameObject.tag = "Oil";

            //��ƼŬ ���� ����
            ParticleSystem.MainModule main = GetComponent<ParticleSystem>().main;
            main.startColor = Color.black;
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
            if (Type == 0) Destroy(gameObject);
            if (Type == 1) Destroy(gameObject);
            if (Type == 2)
            {
                Destroy(gameObject);
                GameManager.I.GameOver();
            }
        }

        // ���� ������ ������ ���, ����
        if (collision.gameObject.tag == "Ground")
        {
            particleObject.Play();
            Render.color = new Color(1f, 1f, 1f, 0f);
            gameObject.tag = "Untagged";
            Invoke("DestroyObject", 0.5f);
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
