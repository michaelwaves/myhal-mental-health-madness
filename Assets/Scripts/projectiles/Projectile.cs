using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile: MonoBehaviour
{
    [SerializeField, Range(1f, 100f)] private float speed = 10f;
    private ParticleSystem ps;
    private SpriteRenderer sr;
    private Rigidbody2D proj;

    private void Awake()
    {
        ps = GetComponent<ParticleSystem>();
        sr = GetComponent<SpriteRenderer>();
        proj.AddForce(Vector3.down);
    }
    void Update()
    {
        transform.position += -transform.right * Time.deltaTime * speed;
    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Player")
        {
            ps.Play();
            sr.enabled = false;
            //new WaitForSecondsRealtime(5);
            Destroy(gameObject, 5f);
        }
        
    }
}
