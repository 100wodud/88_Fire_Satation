using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeObject", 0.3f, 0.2f);
    }

    void MakeObject()
    {
        Instantiate(Object);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
