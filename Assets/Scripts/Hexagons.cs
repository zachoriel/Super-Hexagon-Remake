using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagons : MonoBehaviour
{
    Score score;
    Spawner spawner;

    Rigidbody2D rb;

    bool awardedScore = false;

	// Use this for initialization
	void Start ()
    {
        score = FindObjectOfType<Score>();
        spawner = FindObjectOfType<Spawner>();

        rb = GetComponent<Rigidbody2D>();

        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.localScale -= Vector3.one * spawner.shrinkSpeed * Time.deltaTime;

        if (transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
        }

        if (transform.localScale.x <= .5f && !awardedScore)
        {
            awardedScore = true;
            score.AddScore();
        }
	}
}
