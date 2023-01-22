using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusicController : MonoBehaviour
{
    private AudioSource audios;
    void Awake()
    {
        audios = GetComponent<AudioSource>();
        audios.time = 2f;
        audios.Play();
    }

}
