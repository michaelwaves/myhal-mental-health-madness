using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D item;
    private Vector3 pos;
    private int nextUpdate = 2;
    [SerializeField] private float speed = 100.0f;
    void Start()
    //[SerializeField] private GameObject projectile;
    {
       pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextUpdate) {
            Debug.Log(Time.time + ">=" + nextUpdate);
            // Change the next update (current second+1)
            nextUpdate = Mathf.FloorToInt(Time.time) + 1;
            // Call your fonction
            UpdateEverySecond();
        }
    }
    void UpdateEverySecond()
    {
        //spawn objects
        Rigidbody2D p = Instantiate(item, pos, Quaternion.identity); //prefab must contain rigidbody, collider and mesh
        p.velocity = transform.up * speed;
        //Debug.Log(p.velocity);
    }
}
