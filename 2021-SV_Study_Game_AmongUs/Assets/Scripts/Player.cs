using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Vector3 velocity = Vector3.zero;
    Animator animator; // import Animator as animator

    void Start()
    {
        animator = gameObject.GetComponentInChildren<Animator>();
    }

    void FixedUpdate()
    {
        velocity = Vector3.zero;
        animator.SetBool("IsWalking", false);
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            velocity = Vector3.right;
            animator.SetBool("IsWalking", true);
            transform.localScale = new Vector3(3.3f, 3.3f, 3.3f);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            velocity = Vector3.left;
            animator.SetBool("IsWalking", true);
            transform.localScale = new Vector3(-3.3f, 3.3f, 3.3f);
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            velocity = Vector3.up;
            animator.SetBool("IsWalking", true);
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            velocity = Vector3.down;
            animator.SetBool("IsWalking", true);
        }
        if (Input.GetAxisRaw("Horizontal") > 0 & Input.GetAxisRaw("Vertical") > 0)
        {
            velocity = new Vector3(1,1,0);
            animator.SetBool("IsWalking", true);
            transform.localScale = new Vector3(3.3f, 3.3f, 3.3f);
        }
        if (Input.GetAxisRaw("Horizontal") > 0 & Input.GetAxisRaw("Vertical") < 0)
        {
            velocity = new Vector3(1,-1,0);
            animator.SetBool("IsWalking", true);
            transform.localScale = new Vector3(3.3f, 3.3f, 3.3f);
        }
        if (Input.GetAxisRaw("Horizontal") < 0 & Input.GetAxisRaw("Vertical") > 0)
        {
            velocity = new Vector3(-1,1,0);
            animator.SetBool("IsWalking", true);
            transform.localScale = new Vector3(-3.3f, 3.3f, 3.3f);
        }
        if (Input.GetAxisRaw("Horizontal") < 0 & Input.GetAxisRaw("Vertical") < 0)
        {
            velocity = new Vector3(-1,-1,0);
            animator.SetBool("IsWalking", true);
            transform.localScale = new Vector3(-3.3f, 3.3f, 3.3f);
        }
        transform.position += moveSpeed * velocity * Time.deltaTime;
    }
}
