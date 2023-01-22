using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerAudio : MonoBehaviour
{
    private AudioSource audios;
    private bool active = true;
    void Awake()
    {
        audios = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //audios.time = 0.5f;
        if (collision.gameObject.CompareTag("Player"))
        {
            if (active == true){
                audios.Play();
                audios.time = 0.5f;
                active = false;
            }
           
        }
    }
}
