using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D rb;
    Game_Manager game_Manager;
    public float velocity=1f;
    void Start()
    {
        Time.timeScale=0;
        rb=GetComponent<Rigidbody2D>();//get the rigidbody
        game_Manager=FindObjectOfType<Game_Manager>();//find the game manager
    }
    void Update() 
    {
        if (Input.GetMouseButtonDown(0)&&game_Manager.gameOver==false)
        {
            game_Manager.gameStart=true;//start the game
            Time.timeScale=1;//set the time scale to 1
            game_Manager.gameReadyPanel.SetActive(false);//hide the game ready panel
            rb.velocity=Vector2.zero;//set the velocity to zero
            rb.velocity=Vector2.up*velocity;//set the velocity to up
            game_Manager.audioSource.PlayOneShot(game_Manager.audioClips[0]);//play the audio clip
            
        }
     
    }
    
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("score"))
        {
           game_Manager.score++;//add one to the score
           game_Manager.scoreText.text=game_Manager.score.ToString();//set the score text to the score
           game_Manager.audioSource.PlayOneShot(game_Manager.audioClips[1]);//play the audio clip
        }
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("die"))
        {
           game_Manager.audioSource.PlayOneShot(game_Manager.audioClips[2]);//play the audio clip
           game_Manager.gameoverPanel.SetActive(true);//show the game over panel
           game_Manager.gameOver=true;//set the game over to true
           Time.timeScale=0;//set the time scale to 0
        }
    }
}
