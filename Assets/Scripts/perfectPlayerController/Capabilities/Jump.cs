using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private InputController input = null;
    [SerializeField, Range(0f, 100f)] private float jumpHeight = 3f;
    [SerializeField, Range(0, 5)] private int maxJumps = 2;
    [SerializeField, Range(0f, 100f)] private float downJumpMultiplier = 5f;
    [SerializeField, Range(0f, 100f)] private float upJumpMultiplier = 2f;

    private Rigidbody2D rb;
    private Ground ground;
    private Vector2 velocity;

    private int jumps;
    private float defaultGravity;

    private bool jump;
    private bool onGround;


    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        ground = GetComponent<Ground>();

        defaultGravity = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        jump |= input.RetrieveJumpInput();
    }

    private void FixedUpdate()
    {
        onGround = ground.getonGround();
        velocity = rb.velocity;

        if (onGround)
        {
            jumps = 0;
        }
        if (jump)
        {
            jump = false;
            jumpAction();
        }
        if (rb.velocity.y > 0)
        {
            rb.gravityScale = upJumpMultiplier;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = downJumpMultiplier;
        }
        else if (rb.velocity.y == 0)
        {
            rb.gravityScale = defaultGravity;
        }

        rb.velocity = velocity;

    }
    private void jumpAction()
    {
        if(onGround || jumps< maxJumps)
        {
            jumps += 1;
            float jumpSpeed = Mathf.Sqrt(-3f * Physics2D.gravity.y * jumpHeight);
            if (velocity.y > 0f)
            {
                jumpSpeed = Mathf.Max(jumpSpeed - velocity.y, 0f);
            }
            else if (velocity.y < 0f)
            {
                jumpSpeed += Mathf.Abs(rb.velocity.y);
            }
            velocity.y += jumpSpeed;
        }
    }
}
