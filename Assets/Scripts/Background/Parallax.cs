using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    [SerializeField] private GameObject cam;
    [SerializeField] private float parallax_effect;
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    void Update()
    {
        float dist = (cam.transform.position.x * parallax_effect); //how mmuch is cam moving in x direction from origin
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
    }
}
