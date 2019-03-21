using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        // Since Application.Quit() doesn't work in the editor
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
 