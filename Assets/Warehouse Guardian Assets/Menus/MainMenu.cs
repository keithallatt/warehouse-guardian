using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // to quit the game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }
   
}
 