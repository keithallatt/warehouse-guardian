using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class NextButton : MonoBehaviour
{

    public Sprite[] gallery;
    public Image displayImage;
    public Button nextButton;
    public Button prevButton;
    public int i = 0;

    public void BtnNext()
    {
        if (i + 1 < gallery.Length)
        {
            i++;
        }
    }

    public void BtnPrev()
    {
        if (i - 1 > 0)
        {
            i--;
        }
    }
    void Update()
    {
        displayImage.sprite = gallery[i];
    }
}


