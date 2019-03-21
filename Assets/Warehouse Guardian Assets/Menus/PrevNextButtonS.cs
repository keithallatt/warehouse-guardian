using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

// determines which image to display depending on button clicks
public class NextButton : MonoBehaviour
{
    public Sprite[] gallery;
    public Image displayImage;
    public Button nextButton;
    public Button prevButton;
    public int i = 0;

    // shifts image index when next button is clicked
    public void BtnNext()
    {
        if (i + 1 < gallery.Length)
        {
            i++;
        }
    }

    // shifts image index when the previous button is clicked
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


