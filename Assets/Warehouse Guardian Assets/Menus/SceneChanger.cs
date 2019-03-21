using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // jumping scenes from main menu to game
    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // jumping scenes from game to main menu 
    void update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
  
}
