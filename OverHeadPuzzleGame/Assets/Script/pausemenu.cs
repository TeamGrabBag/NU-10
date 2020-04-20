using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    void Update()
    {
       if (Input.GetButtonDown("Pause Button"))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }

      /* if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }*/
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        //Cursor.visible = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        //Cursor.visible = true;
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        GameObject.FindGameObjectWithTag("Music").GetComponent<music>().StopMusic();
    }

}
