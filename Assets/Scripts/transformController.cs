using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformController : MonoBehaviour
{
    [SerializeField] private int speed = 10;
    Vector2 move;
    // Update is called once per frame
    void Update()
    {
        move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        transform.Translate(move * speed * Time.deltaTime);

        if (Input.GetAxis("Vertical")>0)
        {
            transform.Translate(move * speed * Time.deltaTime);
        }

    }
}
