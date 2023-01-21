using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    //[SerializeField] private Projectile projectile;
    [SerializeField] private Transform origin;
    private SpriteRenderer sr;
    private Quaternion left;
    private Quaternion right;
    // attach script to player
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        left = Quaternion.Euler(0, 0, 0);
        right = Quaternion.Euler(0, 180, 0);
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            // instantiate projectile at origin position, player rotation
            //Instantiate(projectile, origin.transform.position, sr.flipX?right:left);
        }
    }
}
