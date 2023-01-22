using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    private AudioSource audios;
    private void Awake()
    {
        audios = GetComponent<AudioSource>();
    }
    public void ButtonNoise()
    {
        audios.Play();
        audios.time = 0.5f;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("MainLevel");
    }
    public void MMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    
}
