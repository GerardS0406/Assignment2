/*
 * Gerard Lamoureux
 * PlayerMovement.cs
 * Assignment2
 * Handles all player movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 8f;
    private float jumpSpeed = 8f;
    private bool jump = false;
    private bool isJumping = false;

    [SerializeField] private GameObject wings;

    private PlayerController pc;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pc = GetComponent<PlayerController>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && !isJumping && !pc.TryToFly())
        {
            jump = true;
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if(!pc.TryToFly())
        {
            if (wings.activeSelf)
                wings.SetActive(false);
            rb.gravityScale = 2;
            if (jump)
            {
                rb.velocity = new Vector2(horizontal * speed, jumpSpeed);
                jump = false;
                isJumping = true;
            }
            else
            {
                rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
            }
        }
        else
        {
            if (!wings.activeSelf)
                wings.SetActive(true);
            rb.gravityScale = 0;
            rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
    }
}
