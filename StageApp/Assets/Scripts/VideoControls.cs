using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoControls : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    public void PlayVideo()
    {
        videoPlayer.Play();
    }
    public void PauzeVideo()
    {
        videoPlayer.Pause();
    }
    public void StopVideo()
    {
        SceneManager.LoadScene(0);
    }
    
}
