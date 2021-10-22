using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    Rigidbody2D rb;
    public int i = 9;
    public double gravity = 2.2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue movementValue)
    {
        rb.gravityScale = (float) gravity;
        rb.velocity = new Vector2(0, i);
    }

    void FixedUpdate() {
        Debug.Log("test");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Pipes")) {
            Debug.Log("Game over!");
        }
    }
}
