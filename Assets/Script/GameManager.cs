using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Goal[] GoalRef;

    public delegate void ScoreEvent(int PlayerGoal);

    public event ScoreEvent ScorePoint;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < GoalRef.Length; i++)
        {
            GoalRef[i].GoalScore += SendPoint;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendPoint(int PlayerId)
    {
        ScorePoint?.Invoke(PlayerId);
    }
}
