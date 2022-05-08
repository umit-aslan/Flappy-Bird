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
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }

   
    void Update()
    {
        
    }
}
