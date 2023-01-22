using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleProjectileMotion : MonoBehaviour
{
    [SerializeField] 
    private PolygonCollider2D col;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private ParticleSystem ps;
    private AudioSource audios;
    private Vector2 move;
    [SerializeField] private float speed=20f;
    [SerializeField] private float min=-10f;
    [SerializeField] private float max=10f;
    private float i;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<PolygonCollider2D>();
        sr = GetComponent<SpriteRenderer>();
        ps = GetComponent<ParticleSystem>();
        audios = GetComponent<AudioSource>();

        move = Vector2.up * speed*5f+ Vector2.right*speed*Random.Range(min, max)/2f;// Random.Range(Mathf.Abs(min), max) + Vector2.right * Random.Range(min, max);
        StartCoroutine(MoveUP());
        
        Destroy(gameObject, 10f);
    }

    private IEnumerator MoveUP()
    {
        for (i = 0.5f; i>=0f; i-=0.1f)
        {
            rb.AddForce(move);
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            sr.enabled = false;
            ps.Play();
            //audios.Play();
            Destroy(gameObject, 5f);
        }
    }
}
