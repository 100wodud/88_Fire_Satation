using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = -1f;
        float y = 5f;
        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -0.001f, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 플레이어와 닿을 시 패배
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
