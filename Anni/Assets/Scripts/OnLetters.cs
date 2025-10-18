using System;
using UnityEngine;

public class OnLetters : MonoBehaviour
{
    private Vector3 offset;

    private GameObject cameraOb;

    private Camera mainCam;
    
    public bool amDragging = false;

    CameraFollow cameraFollowScript;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //assign the camera follow cam?
        mainCam = Camera.main;

        cameraFollowScript = mainCam.GetComponent<CameraFollow>();
        //i can call the switch camera function here
        

       

    }

    // Update is called once per frame
    void Update()
    {
        if(amDragging)
        {
            //this switches the target to the letter you are currently dragging
            cameraFollowScript.SwitchTarget(gameObject.transform);
        }
        else
        {
            //cameraFollowScript.SwitchTarget()
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - mainCam.ScreenToWorldPoint(Input.mousePosition);
        amDragging = true;
    }

    private void OnMouseDrag()
    {
        Debug.Log("drag the obj");
        Vector3 mouseWorldPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mouseWorldPos.x + offset.x, 
            mouseWorldPos.y + offset.y, transform.position.z);
        
    }

    private void OnMouseUp()
    {
        amDragging = false;
    }
}
