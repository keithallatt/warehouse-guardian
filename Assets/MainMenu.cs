using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // initiates the game scene and loads it to play the game
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // set intial state to game is not paused
    public static bool GameIsPaused = false;

    // to quit the game
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    // updates the scene according to whether the pause or resume selection is selected
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    // initiates the pause scene to pause the game
    void Pause()
    {
        pauseMenuID.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    
    // sets the pause scene off to resume the game
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = false;
    }
}
 