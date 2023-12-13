using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public bool playerDead = false;
    public GameObject deathMenuUI;

    void Start()
    {
        Time.timeScale = 1f;
        deathMenuUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if(playerDead)
        {
            // Debug.Log("Player is dead---------------------->");
            Pause();
        }

    }

    void Pause()
    {
        // Debug.Log("pause");
        deathMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        // Debug.Log("Restarting game...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/Game");
        
    }

    public void LoadMenu()
    {
        // Debug.Log("Loading menu...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenes/MainMenu");
    }

    public void QuitGame()
    {
        // Debug.Log("Quitting game...");
        Application.Quit();
    }
}
