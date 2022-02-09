using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject Player1Display;
    public GameObject Player2Display;
    private int P1Score;
    private int P2Score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player1Display.GetComponent<Text>().text = Convert.ToString(P1Score);
        Player2Display.GetComponent<Text>().text = Convert.ToString(P2Score);
    }

    public void Score(int player)
    {
        if (player == 2)
        {
            P1Score += 1;
        }
        else
        {
            P2Score += 1;
        }
    }

}
