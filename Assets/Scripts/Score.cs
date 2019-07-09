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

    [Header("Difficulty Modifiers")]
    public const float stage1Modifier = 0.1f;
    public const float stage2Modifier = 0.2f;
    public const float stage3Modifier = 0.3f;
    public const float stage4Modifier = 0.4f;
    public const float stage5Modifier = 0.5f;

    void Start()
    {
        spawner = FindObjectOfType<Spawner>();
    }

    void IncreaseDifficulty(float modifier)
    {
        spawner.spawnRate += modifier;
        spawner.shrinkSpeed += modifier;
    }

    public void AddScore()
    {
        animator.SetTrigger("BumpScore");

        score++;
        scoreText.text = "Score: " + score.ToString();

        switch (score)
        {
            case 10:
                IncreaseDifficulty(stage1Modifier);
                break;
            case 25:
                IncreaseDifficulty(stage2Modifier);
                break;
            case 50:
                IncreaseDifficulty(stage3Modifier);
                break;
            case 75:
                IncreaseDifficulty(stage4Modifier);
                break;
            case 100:
                IncreaseDifficulty(stage5Modifier);
                break;
        }
    }
}
