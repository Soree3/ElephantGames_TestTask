using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieRun : MonoBehaviour
{
    public float speed = 2f;
    public bool startRunning = false;
    Rigidbody2D rb;
    private Vector2 velocity;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = new Vector2(1, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    private void FixedUpdate()
    {
        if (startRunning)
        {
            rb.MovePosition(rb.position + velocity * speed * Time.deltaTime);
        }
    }
}
