using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;//score text
    public int score=0;//score of the player
    public AudioSource audioSource;//audio source for the game manager
    public AudioClip[] audioClips;//audio clips for the game manager
    public GameObject gameoverPanel;//game over panel
    public bool gameStart=false;//game start
    public GameObject gameReadyPanel;//game ready panel
    public bool gameOver=false;//game over
    void Start()
    {
        audioSource=GetComponent<AudioSource>();//Get the audio source component
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);//Load the first scene
    }
}
