using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video360 : MonoBehaviour
{

    public GameObject playImage;
    public GameObject pauseImage;
    public VideoPlayer videoPlayer;

    public SceneChanger sceneChanger;

    private bool videoIsOn = false;




    public void OnButtonPress()
    {
        videoIsOn = !videoIsOn;
        playImage.SetActive(!videoIsOn);
        pauseImage.SetActive(videoIsOn);
        if (videoIsOn)
        {
            videoPlayer.Play();
        }
        else
        {
            sceneChanger.FadeToScene(0);
        }
    }

    public void Begin360Video()
    {

    }
}
