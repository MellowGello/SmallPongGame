using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.I))
        {
            this.transform.Translate(0f,speed,0f);
        }
        if (Input.GetKey(KeyCode.K))
        {
            this.transform.Translate(0f,-speed,0f);
        }
    }
}