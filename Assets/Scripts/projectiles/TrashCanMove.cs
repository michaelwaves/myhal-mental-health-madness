using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCanMove : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed=10f;
    private Vector2 velocity;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = Vector2.right * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        velocity = -velocity;
    }

    private void FixedUpdate()
    {
        rb.AddForce(velocity);
    }
}
