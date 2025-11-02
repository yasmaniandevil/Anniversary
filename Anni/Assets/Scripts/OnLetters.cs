using System;
using UnityEngine;
using System.Collections;

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
            
            
        }
        else
        {
            //cameraFollowScript.SwitchTarget()
        }
    }

    
    private void OnMouseDown()
    {
        Vector3 mouseWorldPos = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        offset = transform.position - mouseWorldPos;
        amDragging = true;
    }

    private void OnMouseDrag()
    {
        Debug.Log("drag the obj");
        Vector3 mouseWorldPos = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        transform.position = new Vector3(mouseWorldPos.x + offset.x, 
            mouseWorldPos.y + offset.y, transform.position.z);
        
    }

    private void OnMouseUp()
    {
        amDragging = false;
        
        //this switches the target to the letter you are currently dragging
        cameraFollowScript.SwitchTarget(gameObject.transform);
    }
    
    
}
