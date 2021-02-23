using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class right : MonoBehaviour,IVirtualButtonEventHandler {
    private GameObject button;
    private GameObject cube;
    // Use this for initialization
    void Start()
    {
        button = GameObject.Find("right");
        cube = GameObject.Find("Cube");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("right button pressed");
        cube.transform.RotateAround(Vector3.up, 45);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("right button released");
    }
}
