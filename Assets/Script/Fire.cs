using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{
    float speed = -0.0002f;
    float addSpeed = 0;
    int gauge = 0;
    // Start is called before the first frame update
    void Start()
    {
        float x = -1f;
        float y = 5f;
        transform.position = new Vector3(x, y, 0);

        if (GameManager.I.GameLevel == 1)
        {
            speed = -0.00025f;
        } else if(GameManager.I.GameLevel == 2)
        {
            speed = -0.0003f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if ((int)(GameManager.I.time / 20) > addSpeed & GameManager.I.GameLevel == 2)
        {
            addSpeed = (int)(GameManager.I.time / 20) * -0.00005f;
        }
        transform.position += new Vector3(0, speed + addSpeed, 0);

        if(PlayerManager.I.gauge > gauge)
        {
            gauge = PlayerManager.I.gauge;
            transform.position += new Vector3(0, 0.1f, 0);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 플레이어와 닿을 시 패배
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.I.GameOver();
        }
    }
}
