using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game_Manager : MonoBehaviour
{
 
    public TextMeshProUGUI scoreText;
    public int score=0;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public GameObject gameoverPanel;
    public bool gameStart=false;
    public GameObject gameReadyPanel;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }

   
    void Restart()
    {
        
    }
}
