using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieRun : MonoBehaviour
{
    public float speed = 2f;
    public bool startRunning = false;
    Rigidbody2D rb;
    [SerializeField] private Vector2 velocity;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
        if (startRunning)
        {
            rb.MovePosition(rb.position + velocity * speed * Time.deltaTime);
        }
    }
}
