using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private InputController input = null;
    [SerializeField, Range(0f, 100f)] private float maxSpeed = 6f;
    [SerializeField, Range(0f, 100f)] private float maxAcceleration= 80f;
    [SerializeField, Range(0f, 100f)] private float maxAirAcceleration = 20f;
    [SerializeField, Range(0f, 10f)] private float airFriction = 4f;


    private Vector2 desiredVelocity;
    private Vector2 currentVelocity;
    private Vector2 direction;
    private Ground ground;
    private float acceleration;
    private Rigidbody2D rb;
    //private ParticleSystem ps;

    private float maxSpeedChange;
    private bool onGround;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //ps = GetComponent<ParticleSystem>();
        ground = GetComponent<Ground>();
    }
   
    // Update is called once per frame
    void Update()
    {
        direction.x = input.RetrieveMoveInput();
        if (input.RetrieveMoveInput() !=0)
        {
            //ps.Play();
        }
        if (direction.x != 0)
        {
            desiredVelocity = new Vector2(direction.x, 0f) * Mathf.Max(maxSpeed - ground.getfriction(), 0f);
        }
        //desiredVelocity = new Vector2(direction.x, 0f) * Mathf.Max(maxSpeed - ground.getfriction(), 0f);
        else
        {
            if(rb.velocity.x < 0)
            {
                desiredVelocity.x = desiredVelocity.x + Time.deltaTime * airFriction;
            }

            if(rb.velocity.x >0)
            {
                desiredVelocity.x = desiredVelocity.x - Time.deltaTime * airFriction;
            }
            
        }
        


    }

    //do physics stuff in fixedupdate
    private void FixedUpdate()
    {
        onGround = ground.getonGround();
        currentVelocity = rb.velocity;

        acceleration = onGround ? maxAcceleration : maxAirAcceleration;
        maxSpeedChange = acceleration * Time.deltaTime;
        currentVelocity.x = Mathf.MoveTowards(currentVelocity.x, desiredVelocity.x, maxSpeedChange);

        rb.velocity = currentVelocity;
    }
}
