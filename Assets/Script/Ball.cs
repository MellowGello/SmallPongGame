using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    public float CurSpeedX;
    public float CurSpeedY;
    private Rigidbody rb;
    public UI UIScript;
    void Start()
    {
        CurSpeedX = Random.Range(-CurSpeedX, CurSpeedX);
        CurSpeedY = Random.Range(-CurSpeedY, CurSpeedY);
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(CurSpeedX, CurSpeedY, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //this.transform.position = new Vector2(this.transform.position.x + CurSpeedX, this.transform.position.y + CurSpeedY);
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.CompareTag("Untagged"))
        {
            CurSpeedY = -CurSpeedY;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            CurSpeedX = -CurSpeedX;
        }*/
        if (collision.gameObject.CompareTag("Goal"))
        {
            ResetBall();
        }
    }
    
    private void ResetBall()
    {
        
        CurSpeedX = Random.Range(-10f, 10f);
        CurSpeedY = Random.Range(-10f, 10f);
        rb.velocity = new Vector3(CurSpeedX, CurSpeedY, 0);
        this.transform.localScale =
            new Vector3(Random.Range(0.2f, 1.5f), Random.Range(0.2f, 1.5f), Random.Range(0.2f, 1.5f));
        this.transform.position = new Vector2(0f, 0f);
        GetComponent<Renderer>().material.color =
            new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
    
}
