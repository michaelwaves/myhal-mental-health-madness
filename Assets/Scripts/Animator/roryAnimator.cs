using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roryAnimator : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public float hori;
    private bool is_flipped = false;
    private bool is_jumping = false;
    private float vert_velocity;

    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    

    }

    // Update is called once per frame
    void Update()
    {
        vert_velocity = rb.velocity.y;
        is_jumping = Mathf.Abs(vert_velocity) > 0.1;
        if (is_jumping)
        {
            anim.SetBool("is_jumping", true);
        }
        else if (Mathf.Abs(vert_velocity) < 0.1)
        {
            anim.SetBool("is_jumping", false);
        }
        if (is_jumping && Input.GetKeyDown("space"))
        {
            anim.SetBool("is_jumping", false);
        }
        hori = Input.GetAxis("Horizontal");
        anim.SetFloat("horizontal", Mathf.Abs(hori));
        
        //transform.rotation = Quaternion.Euler(0, is_flipped == true ? 180 : 0, 0);
        
    }
    private void FixedUpdate()
    {
        if (rb.velocity.x > 0.1)
        {
            sr.flipX = true;
            is_flipped = true;
        }
        else if (rb.velocity.x < -0.1)
        {
            sr.flipX = false;
            is_flipped = false;
        }
        else if (rb.velocity.x == 0)
        {
            sr.flipX = is_flipped;
        }
        is_flipped = sr.flipX;
    }
}
