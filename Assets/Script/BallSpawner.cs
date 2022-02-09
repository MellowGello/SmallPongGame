using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate((Ball));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
