using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;

public class story_btn : MonoBehaviour,IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("Videobtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("BIN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("BIN Realesed");
    }
}
