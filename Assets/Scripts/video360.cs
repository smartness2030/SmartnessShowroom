using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video360 : MonoBehaviour
{

    public GameObject playImage;
    public GameObject pauseImage;
    public VideoPlayer videoPlayer;

    private bool videoIsOn = false;




    public void OnButtonPress()
    {
        videoIsOn = !videoIsOn;
        playImage.SetActive(!videoIsOn);
        pauseImage.SetActive(videoIsOn);
    }

    public void Begin360Video()
    {

    }
}
