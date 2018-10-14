using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip technoLoop, gameOver;

	// Use this for initialization
	void Start ()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        MusicLoop();
	}

    public void MusicLoop()
    {
        audioSource.clip = technoLoop;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void GameOver()
    {
        audioSource.Stop();
        audioSource.clip = gameOver;
        audioSource.loop = false;
        audioSource.Play();
    }
}
