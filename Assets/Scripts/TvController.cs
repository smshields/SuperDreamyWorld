using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class TvController : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoplayer;
    public GameObject tvscreen;
    void Start()
    {
        //videoplayer = gameObject.GetComponent<VideoPlayer>();
        videoplayer.targetMaterialRenderer = tvscreen.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (videoplayer.targetMaterialRenderer == null)
        //    return;
        
    }
    public void PlayorPauseVideo()
    {
        if(videoplayer.isPlaying==true)
        {
            videoplayer.Pause();
        }
        else 
        {
            videoplayer.Play();
        }
    }
}
