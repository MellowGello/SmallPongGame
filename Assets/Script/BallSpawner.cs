using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallSpawner : MonoBehaviour
{
    public GameObject BallObject;
    public GameManager GMRef;

    private int count = 0;

    private int ballcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        GMRef.ScorePoint += SpawnBall;
    }

    private void OnDisable()
    {
        GMRef.ScorePoint -= SpawnBall;
    }

    public void SpawnBall(int nothing)
    {
        count += 1;
        if (count >= ballcount)
        {
            count = 0;
            ballcount += 1;
            GameObject Ball = BallObject;
            Instantiate(Ball);
            Ball.transform.position = new Vector3(0, Random.Range(-2, 2), 0);
        }
        
    }
}
