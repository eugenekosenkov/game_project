using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public Player player;

    private Rigidbody2D rigidbody2d;
    private Vector2 movement;

    private bool looksLeft = true;


    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rigidbody2d.MovePosition(rigidbody2d.position + movement * player.moveSpeed * Time.fixedDeltaTime);

        if ((movement.x > 0) && looksLeft)
        {
            Flip();
        }
        else if ((movement.x < 0) && !looksLeft)
        {
            Flip();
        }

        //if (movement.x != 0 || movement.y != 0)
        //{
            //animator.Play("move");
        //}
        //else animator.Play("move");

    }

    private void Flip()
    {
        looksLeft = !looksLeft;
        transform.Rotate(0f, 180f, 0f);
    }

}