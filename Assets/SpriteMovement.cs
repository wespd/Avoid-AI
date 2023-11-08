using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this to set the movement speed.
    
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from arrow keys or WASD.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement vector.
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * moveSpeed;

        // Apply the movement to the Rigidbody2D.
        rb.velocity = movement;
    }
}