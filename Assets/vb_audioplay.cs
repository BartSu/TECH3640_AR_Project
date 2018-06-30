using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_audioplay : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtnObj;
    public AudioSource StoryAudio;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("AudioPlaybtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        StoryAudio.Stop();
        Debug.Log("BIN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        StoryAudio.Play();
        Debug.Log("BIN Realesed");
    }
}
