using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text[] PlayerDisplay;
    private int[] PlayerScore;

    public GameManager GMRef;

    void Start()
    {
        PlayerScore = new int[PlayerDisplay.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnEnable()
    {
        GMRef.ScorePoint += GoalScoreEvent;
    }

    private void OnDisable()
    {
        GMRef.ScorePoint -= GoalScoreEvent;
    }

    public void GoalScoreEvent(int playerscore)
    {
        if (playerscore == 2)
        {
            PlayerScore[0] += 1;
            PlayerDisplay[0].text = Convert.ToString(PlayerScore[0]);
        }
        else
        {
            PlayerScore[1] += 1;
            PlayerDisplay[1].text = Convert.ToString(PlayerScore[1]);
        }
    }

    
}
