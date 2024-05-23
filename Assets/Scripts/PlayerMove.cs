using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Vector2 playerDirection;
    private bool isGrounded;
    public ParticleSystem dustParticles;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") == true) // && isGrounded == true)
        {
            rb.gravityScale *= -1;
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            transform.localScale = new Vector3(1, transform.localScale.y * -1, 1);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerSpeed, rb.velocity.y);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;
            dustParticles?.Play();
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;
            dustParticles?.Stop();
        }
    }

    
        


}