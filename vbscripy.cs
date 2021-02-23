using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbscripy : MonoBehaviour,IVirtualButtonEventHandler {
    private GameObject button;
    private GameObject cat;
    // Use this for initialization
    void Start()
    {
        button = GameObject.Find("button");
        cat = GameObject.Find("catt");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("button pressed");
        cat.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("button released");
        cat.GetComponent<Animation>().Stop();
    }

}
