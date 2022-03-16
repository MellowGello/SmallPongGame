using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject target = GameObject.CreatePrimitive(PrimitiveType.Cube);
        for (int i = 0; i < 10; i++)
        {
            Instantiate(target);
            target.transform.position = new Vector3(Mathf.PerlinNoise(i,0),0,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
