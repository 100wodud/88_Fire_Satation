using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2.7f, 2.7f);
        float y = -3.9f;
        transform.position = new Vector3(x, y, 0f);
    }
    float currTime;

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;

        if (currTime > 10 )
        {
            float newX = Random.Range(-2.7f, 2.7f);
            float newY = -3.9f;
            transform.position = new Vector3(newX, newY, 0);

            currTime = 0;
        }

    }
}
