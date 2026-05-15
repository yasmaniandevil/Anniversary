using System;
using UnityEngine;

public class OnLetters : MonoBehaviour
{
    private Vector3 offset;

    private GameObject cameraOb;

    private Camera mainCam;
    
    public bool amDragging = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
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
