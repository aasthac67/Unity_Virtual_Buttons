using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class left : MonoBehaviour,IVirtualButtonEventHandler {
    private GameObject button1;
    private GameObject cube;
    // Use this for initialization
    void Start()
    {
        button1 = GameObject.Find("left");
        cube = GameObject.Find("Cube");
        button1.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("left button pressed");
        cube.transform.RotateAround(Vector3.down, 45);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("left button released");
    }
}
