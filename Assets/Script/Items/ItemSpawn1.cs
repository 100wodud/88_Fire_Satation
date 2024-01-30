using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn1 : MonoBehaviour
{
    public GameObject Item1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeItem", 5f, 5f);
    }

    void MakeItem()
    {
        Instantiate(Item1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
