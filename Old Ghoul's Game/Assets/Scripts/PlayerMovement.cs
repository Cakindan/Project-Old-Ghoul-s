using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    public Rigidbody2D body;
    private Animator animation;
    private BoxCollider2D boxCollider;
    private bool grounded;

    private void Awake()
    {
        //Grabbing the referenced for rigidbody 2d and animator from object
        body = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float horizontalInput = (Input.GetAxis("Horizontal"));
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        // Jump player character
        if (Input.GetKey(KeyCode.Space) && grounded)
            Jump();

        //Set animator parameters
        animation.SetBool("grounded", grounded);

        if (Input.GetMouseButton(0))
            animation.SetTrigger("Fire");

    }

    //Code if the player has jump animation
    public void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        grounded = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
        if (collision.gameObject.tag.Equals ("Enemy"))
        {
            animation.SetBool("hurt", true);
        }
    }

}
