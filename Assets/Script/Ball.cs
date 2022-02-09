using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private float CurSpeedX = 0.1f;
    private float CurSpeedY = 0.1f;
    public UI UIScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector2(this.transform.position.x + CurSpeedX, this.transform.position.y + CurSpeedY);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Untagged"))
        {
            CurSpeedY = -CurSpeedY;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            CurSpeedX = -CurSpeedX;
        }
        else if (collision.gameObject.CompareTag("Player 2 Goal"))
        {
            UIScript.Score((2));
            ResetBall();
        }
        else if (collision.gameObject.CompareTag("Player 1 Goal"))
        {
            UIScript.Score((1));
            ResetBall();
        }
    }
    
    private void ResetBall()
    {
        CurSpeedX = Random.Range(-0.4f, 0.5f);
        CurSpeedY = Random.Range(-0.4f, 0.5f);
        this.transform.localScale =
            new Vector3(Random.Range(0.2f, 1.5f), Random.Range(0.2f, 1.5f), Random.Range(0.2f, 1.5f));
        this.transform.position = new Vector2(0f, 0f);
    }
}
