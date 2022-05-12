using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.05f;

    private Rigidbody2D rb;

    [SerializeField]
    private float jumpForce = 350f;

    [SerializeField]
    private int Player_HP = 20;

    private int jumpCount = 0;
    [SerializeField]
    private float g = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        Physics.gravity = new Vector3(0, g, 0);

        Vector2 position = transform.position;

        if (Input.GetKey("left"))
        {
            position.x -= speed;
        }
        else if (Input.GetKey("right"))
        {
            position.x += speed;
        }
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space)&& this.jumpCount < 1)
        {
            this.rb.AddForce(transform.up * jumpForce);
            jumpCount++;
        }

        rb.gravityScale = g;

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }
    }
}