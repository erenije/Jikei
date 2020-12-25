using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;
    public bool faceRight = true;
    public SpriteRenderer sr;
    public float jumpForce = 2f;
    public bool onGround;
    public Transform GroundCheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;
    public diespace1 dead;
    [SerializeField] private AudioSource Jumping;
    [SerializeField] private AudioSource Sdeath;
    [SerializeField] private AudioSource Money;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Walk();
        Reflect();
        Jump();
        CheckingGround();
    }

    void Reflect()
    {
        if((moveVector.x > 0 && !faceRight)||(moveVector.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }
    
    void Walk()
    { 
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            Jumping.Play();
        }
        
    }

    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
        anim.SetBool("OnGround", onGround);
    }

    public void Death()
    {
        Sdeath.Play();
        dead.Pause();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cherry")
        {
            Money.Play();
            Collect.TheCherry += 1;
            Destroy(collision.gameObject);
        }
    }
    /*void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name.Equals("tiles"))
        coll.transform.parent = transform;
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.name.Equals("tiles"))
            coll.transform.parent = null;
    }*/
}
