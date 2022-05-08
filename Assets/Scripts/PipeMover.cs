using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
        transform.Translate(Vector2.left*Time.deltaTime*3);
    }
}
