using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triangleblue : MonoBehaviour {

    public GameObject blue;
    // Use this for initialization
    void Start()
    {
        // blue = transform.Find("BlueBall").gameObject;

       // blue.GetComponentInParent<WhiteBall>().lol = 4;
        blue.GetComponentInParent<BlueBall>().hpnew = 4;
    }



    // Update is called once per frame
    void Update()
    {
        // blue = transform.Find("BlueBall").gameObject;

       // blue.GetComponentInParent<WhiteBall>().lol = 4;
        blue.GetComponentInParent<BlueBall>().hpnew = 4;
    }
}
