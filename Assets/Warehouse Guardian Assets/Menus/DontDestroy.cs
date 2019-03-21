using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{ 
    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        GameObject[] objs = GameObject.FindGameObjectsWithTag("menuMusic");

        // Continuously play music on the main menu
        if (objs.Length > 1)
            Destroy(this.gameObject);

        // Stops playing menu music when in game level scene
        // Game scene will cue different music
        if (sceneName == "SampleScene")
            DontDestroyOnLoad(this.gameObject);
    }
}

