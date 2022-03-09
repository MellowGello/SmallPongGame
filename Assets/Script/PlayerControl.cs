using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public KeyCode UpInput;
    public KeyCode DownInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(UpInput))
        {
            this.transform.Translate(0f,speed,0f);
        }
        if (Input.GetKey(DownInput))
        {
            this.transform.Translate(0f,-speed,0f);
        }
    }
}
