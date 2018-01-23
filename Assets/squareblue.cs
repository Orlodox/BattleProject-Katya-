using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareblue : MonoBehaviour {

    public GameObject blue;

    void Start()
    {
        GameObject.Find("BlueWarrior(Clone)").GetComponentInChildren<Locator>().GetComponent<CircleCollider2D>().radius = 4;
        //GameObject.Find("WhiteWarrior(Clone)").GetComponentInChildren<Locator>().GetComponent<CircleCollider2D>().radius = 4;
    }


    void Update()
    {
        GameObject.Find("BlueWarrior(Clone)").GetComponentInChildren<Locator>().GetComponent<CircleCollider2D>().radius = 4;
        // blue.GetComponentInParent<Locator>().GetComponent<CircleCollider2D>().radius = 4;
    }
}
