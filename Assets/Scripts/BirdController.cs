using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    
    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity=Vector2.up*Time.deltaTime*400;
            
        }
    }
}
