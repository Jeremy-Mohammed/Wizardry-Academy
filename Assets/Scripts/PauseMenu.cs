using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void ReturnToMenu (){
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public static bool IsGamePaused = false;
    public GameObject pauseMenuUI;
    public GameObject instructionMenuUI;
    public GameObject optionsMenuUI;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (IsGamePaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    void Resume () {
        pauseMenuUI.SetActive(false);
        instructionMenuUI.SetActive(false);
        optionsMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        IsGamePaused = false;

    }

    void Pause () {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        IsGamePaused = true;
    }

}

