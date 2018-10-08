using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Editor Setup")]
    public GameObject gameOverPanel;
    public Animator animator;

    [Header("Player Settings")]
    [SerializeField] float moveSpeed = 600f;

    float movement = 0f;

	// Update is called once per frame
	void Update ()
    {
        movement = Input.GetAxisRaw("Horizontal");
	}

    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    void DisplayGameOver()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
        animator.SetTrigger("GameOver");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        DisplayGameOver();
    }
}
