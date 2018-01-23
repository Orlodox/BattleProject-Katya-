using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kvadratblue : MonoBehaviour {

    public GameObject blue;

    void Start()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Square")
        {
            GameObject.Find("Locator").GetComponent<CircleCollider2D>().radius = 4;
        }
    }

    void Update()
    {
        
    }
}
