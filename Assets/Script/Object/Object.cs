using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public SpriteRenderer Render;
    public Sprite Water;
    public Sprite Oil;

    public static Object instance;

    private Rigidbody2D ObjectRigid;

    public int Type = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Type=0 일 때 object 크기 랜덤
        float size = Random.Range(0.15f, 0.3f);
        transform.localScale = new Vector3(size, size, 1);

        //x축 -3~3 까지 랜덤 위치 생성
        float x = Random.Range(-3.0f, 3.0f);
        transform.position = new Vector3(x, 5.0f, 0);

        //object 속도 조절
        ObjectRigid = GetComponent<Rigidbody2D>();
        float speed = Random.Range(0.5f, 4.0f);
        ObjectRigid.drag = speed;
        Render.sprite = Water;

        //object 이미지 변경 및 타입 변경
        int color = Random.Range(0, 101);
        if (color <= 10)
        {
            Render.sprite = Oil;
            Type = 1;
            transform.localScale = new Vector3(0.2f, 0.2f, 1);
            Render.color = new Color(1f, 1f, 1f, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {    
        //플레이어와 닿을시 메서드
        if (collision.gameObject.tag == "Player")
        {
            //Destroy(gameObject);
        }

        // 게임 구역을 나가는 경우, 제거
        if (collision.gameObject.tag == "Ground")
        {
            //Destroy(gameObject);
        }
    }

}
