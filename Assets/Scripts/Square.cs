using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour {
    public GameObject blue;

    void Start () {
        GameObject.Find("WhiteWarrior(Clone)").GetComponentInChildren<Locator>().GetComponent<CircleCollider2D>().radius = 4;
        //GameObject.Find("WhiteWarrior(Clone)").GetComponentInChildren<Locator>().GetComponent<CircleCollider2D>().radius = 4;
    }
	
	
	void Update () {
         GameObject.Find("WhiteWarrior(Clone)").GetComponentInChildren<Locator>().GetComponent<CircleCollider2D>().radius = 4;
       // blue.GetComponentInParent<Locator>().GetComponent<CircleCollider2D>().radius = 4;
    }
}
