using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButton : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;
    private GameObject button;
    private AudioSource audios;
    private bool activated=true;

    private void Awake()
    {
        buttons = GameObject.FindGameObjectsWithTag("button");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            button = buttons[Random.Range(0, buttons.Length)];
            if (button.transform.GetChild(0).gameObject.activeSelf==false && activated)
            {
                button.transform.GetChild(0).gameObject.SetActive(true);
                audios = button.transform.GetChild(0).gameObject.GetComponent<AudioSource>();
                audios.Play();
                activated = false;
            }
         


        }
    }
}
