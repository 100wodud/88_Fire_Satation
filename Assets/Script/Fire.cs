using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
