using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public GameObject Item;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeItem", 5f, 5f);
    }

    void MakeItem()
    {
        Instantiate(Item);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
