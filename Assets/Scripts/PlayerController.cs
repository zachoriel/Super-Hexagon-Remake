using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Editor Setup")]
    public GameObject gameOverPanel;
    public Animator animator;
    SoundManager sounds;

    [Header("Player Settings")]
    [SerializeField] float moveSpeed = 600f;

    float movement = 0f;

    bool leftPointer, rightPointer;

    void Start()
    {
        sounds = FindObjectOfType<SoundManager>();
    }

    // Update is called once per frame
    void Update ()
    {
        movement = Input.GetAxisRaw("Horizontal");

        if (leftPointer == true)
        {
            movement = -1f;
        }

        if (rightPointer == true)
        {
            movement = 1f;
        }
    }

    void FixedUpdate()
    {
        if (movement != 0)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
        }
    }

    #region MobilePointerEvents
    public void PointerDownLeft()
    {
        leftPointer = true;
    }
    public void PointerUpLeft()
    {
        leftPointer = false;
    }
    public void PointerDownRight()
    {
        rightPointer = true;
    }
    public void PointerUpRight()
    {
        rightPointer = false;
    }
    #endregion

    void DisplayGameOver()
    {
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
        animator.SetTrigger("GameOver");

        sounds.GameOver();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        DisplayGameOver();
    }
}
