using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    void Update()
    { 
        transform.Translate(Vector2.left*Time.deltaTime*2);//Pipe moves left
    }
}
