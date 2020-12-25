using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    [SerializeField] private AudioSource SDeath;

    [Header("Stats")] public float speed;
    public float bounceForce;
    private int direction = 1;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        animator.SetFloat("Speed", rb.velocity.magnitude);
        
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.right * (speed * direction);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyBorder"))
        {
            direction *= -1;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<PlayerMove>())
        {
            if (other.GetContact(0).normal.y < 0f)
            {
                animator.SetTrigger("Death");
                direction = 0;
                other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, bounceForce), ForceMode2D.Impulse);
                SDeath.Play();
            }
            else
            {
                other.gameObject.GetComponent<PlayerMove>().Death();
            }
        }
    }

    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
