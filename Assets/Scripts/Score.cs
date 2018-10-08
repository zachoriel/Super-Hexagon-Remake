using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    Spawner spawner;

    [Header("Editor Setup")]
    public Animator animator;

    [Header("Score")]
    public TextMeshProUGUI scoreText;
    public int score;

    void Start()
    {
        spawner = FindObjectOfType<Spawner>();
    }

    void IncreaseDifficulty()
    {
        spawner.spawnRate *= 2f;
        spawner.shrinkSpeed *= 2f;
    }

    public void AddScore()
    {
        animator.SetTrigger("BumpScore");

        score++;
        scoreText.text = "Score: " + score.ToString();

        //if (score == 10)
        //{
        //    IncreaseDifficulty();
        //}

        //if (score == 25)
        //{
        //    IncreaseDifficulty();
        //}

        //if (score == 50)
        //{
        //    IncreaseDifficulty();
        //}
    }
}
