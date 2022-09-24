using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    public enum Facing
    {
        Up, 
        Right,
        Down,
        Left
    }

    public float speed = 1;

    public Facing facing = Facing.Down;

    Rigidbody2D rb;

    Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        switch (facing)
        {
            case Facing.Up:
                animator.SetFloat("lastMoveY", 1);
                break;
            case Facing.Right:
                animator.SetFloat("lastMoveX", 1);
                break;
            case Facing.Down:
                animator.SetFloat("lastMoveY", -1);
                break;
            case Facing.Left:
                animator.SetFloat("lastMoveX", -1);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;

        animator.SetFloat("moveX", rb.velocity.x);

        animator.SetFloat("moveY", rb.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("lastMoveX", Input.GetAxis("Horizontal"));
            animator.SetFloat("lastMoveY", Input.GetAxis("Vertical"));
        }
    }
}
