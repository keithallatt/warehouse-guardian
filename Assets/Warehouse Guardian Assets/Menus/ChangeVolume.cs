using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    public Slider Volume;
    public AudioSource myMusic;

    void Update()
    {
        // Further silence volume because original is too loud
        myMusic.volume = Volume.value / 10;
    }
}

