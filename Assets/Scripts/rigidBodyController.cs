using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidBodyController : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 move;
    [SerializeField] private float speed = 200f;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.AddForce(move * speed * Time.deltaTime);
       
        //rb.velocity = move*
    }

    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

}
