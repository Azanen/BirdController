using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject menuPauseUI;
    public GameObject player;
    public string menuPrincipal;

    void Update()
    {
       if (Input.GetButtonDown("Pause"))
        {
            if (isPaused == true)
            {
                Reprendre();
            }
            else
            {
                SurPause();
            }
        }
    }

    public void Reprendre() //fonction pour le bouton "reprendre" aussi
    {
        menuPauseUI.SetActive(false);
        Time.timeScale = 1f; 
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked; 
        player.GetComponent<PlayerMovement>().enabled = true;
    }

    void SurPause()
    {
        menuPauseUI.SetActive(true);
        Time.timeScale = 0f; //met le jeu sur pause
        isPaused = true;
        Cursor.lockState = CursorLockMode.None; //fait reapparaitre le curseur
        player.GetComponent<PlayerMovement>().enabled = false; //fait qu'on ne peut pas "dash" durant le menu
    }

    public void LoadMenu()
    {
        Debug.Log("loadingMenuPrincipal");
        SceneManager.LoadScene(menuPrincipal);
    }

    public void Quitter()
    {
        Debug.Log("Quitte le jeu");
        Application.Quit();
    }
}
