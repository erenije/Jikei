using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    [SerializeField]
    int speed;
    [SerializeField]
    int jumpForce;
    [SerializeField]
    Transform groundCheck;

    bool isGrounded;
  private void Start()
  {
      animator = GetComponent<Animator>();
      rb = GetComponent<Rigidbody2D>();
      sprite = GetComponent<SpriteRenderer>();
  }

  private void FixedUpdate()
  {
      if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
      {
          isGrounded = true;
      }
      else
      {
          isGrounded = false;
      }
      if (Input.GetKey(KeyCode.D))
      {
          rb.velocity = new Vector2(speed, rb.velocity.y);

          if(isGrounded)
            animator.Play("Player_Run");

        sprite.flipX = false;
      }
      else if (Input.GetKey(KeyCode.A))
      {
          rb.velocity = new Vector2(-speed, rb.velocity.y);

          if(isGrounded)
            animator.Play("Player_Run");

        sprite.flipX = true;
      }
      else
      {
          rb.velocity = new Vector2(0, rb.velocity.y);
          if(isGrounded)
          animator.Play("Player_idle");
      }
      if (Input.GetKey(KeyCode.W) && isGrounded == true)
      {
          rb.velocity = new Vector2(rb.velocity.x, jumpForce);
          animator.Play("Player_Jump");
      }
  }
}
