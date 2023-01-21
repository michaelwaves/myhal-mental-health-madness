using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoodleProjectile: MonoBehaviour
{
    [SerializeField, Range(1f, 100f)] private float speed = 10f;
    private ParticleSystem ps;
    private SpriteRenderer sr;

    private void Awake()
    {
        ps = GetComponent<ParticleSystem>();
        sr = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        transform.position += -transform.right * Time.deltaTime * speed;
    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag!= "Player")
        {
            ps.Play();
            sr.enabled = false;
            //new WaitForSecondsRealtime(5);
            ///Destroy(gameObject);
        }
        
    }
}
