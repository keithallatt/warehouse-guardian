 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour
{
    public Slider Volume;
    public AudioSource myMusic;

    // manipulates volume according to slider 
    void Update()
    {
        // further silence volume since original is too loud
        myMusic.volume = Volume.value / 10;
    }
}

