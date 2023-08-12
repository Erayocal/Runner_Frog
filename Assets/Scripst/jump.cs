using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce;
    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private float jumpTimeCounter;
    public float jumpTime;
    public Animator animator;
    [SerializeField] private AudioSource jumpsound;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        animator= GetComponent<Animator>();
    }
    void Update()
    {
        
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        
        if (isGrounded == true && Input.GetKeyDown(KeyCode.W))
        {
           
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
            jumpsound.Play();
            animator.SetBool("Jump",true);
        }
        if (Mathf.Approximately(rb.velocity.y, 0) && animator.GetBool("Jump"))
        {
            animator.SetBool("Jump", false);
        }
    }
}
