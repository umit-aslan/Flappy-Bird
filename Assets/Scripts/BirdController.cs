using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D rb;
    Game_Manager game_Manager;
    
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        game_Manager=FindObjectOfType<Game_Manager>();
    }
    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity=Vector2.up*Time.deltaTime*270;
            game_Manager.audioSource.PlayOneShot(game_Manager.audioClips[0]);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("score"))
        {
           game_Manager.score++;
           game_Manager.scoreText.text=game_Manager.score.ToString();
           game_Manager.audioSource.PlayOneShot(game_Manager.audioClips[1]);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("die"))
        {
           game_Manager.audioSource.PlayOneShot(game_Manager.audioClips[2]);
           Time.timeScale=0;
        }
    }
}
