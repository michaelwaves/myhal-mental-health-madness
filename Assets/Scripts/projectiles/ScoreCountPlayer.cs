using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreCountPlayer : MonoBehaviour
{
    private AudioSource audios;
    private void Awake()
    {
        audios = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("doggo"))
        {
            ScoreScript.scoreValue += 10;
        }
        if (collision.gameObject.CompareTag("drug"))
        {
            ScoreScript.scoreValue -= 5;
            audios.time = 0.5f;
            audios.Play();
            

        }
    }

}
