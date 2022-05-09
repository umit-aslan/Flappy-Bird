using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score=0;
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public GameObject gameoverPanel;
    public bool gameStart=false;
    public GameObject gameReadyPanel;
    public bool gameOver=false;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
