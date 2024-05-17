using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideshowController : MonoBehaviour
{
    public Image slideshowImage;
    public Sprite[] slides;
    private int currentSlide;

    public void ChangeSlide(int change)
    {
        currentSlide = currentSlide + change;
        currentSlide = currentSlide % slides.Length;
        if (currentSlide < 0) { currentSlide = slides.Length-1; }

        slideshowImage.sprite = slides[currentSlide];
    }
}
