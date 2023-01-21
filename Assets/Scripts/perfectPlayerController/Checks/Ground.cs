using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    private bool onGround;
    private float friction;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        evaluateCollision(collision);
        retrieveFriction(collision);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        evaluateCollision(collision);
        retrieveFriction(collision);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        onGround=false;
        friction=0;
    }

    //is the collision w flat surface
    private void evaluateCollision(Collision2D collision)
    {
        for (int i=0; i<collision.contactCount; i++)
        {
            Vector2 normal = collision.GetContact(i).normal;
            onGround |= normal.y >= 0.9f;
            Debug.Log(onGround);
        }
    }

    //does collision have physics material w friction value
    private void retrieveFriction(Collision2D collision)
    {
        PhysicsMaterial2D material = collision.rigidbody.sharedMaterial;
        friction = 0;
        if(material != null)
        {
            //friction = material.friction;
        }
    }
    
    //make functions that return friction and onGround
    public bool getonGround()
    {
        return onGround;
    }

    public float getfriction()
    {
        return friction;
    }
}
