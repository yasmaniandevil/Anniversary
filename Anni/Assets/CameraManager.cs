using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CameraManager : MonoBehaviour
{
    public List <Camera> camerasList = new List<Camera>();
    //private List <int> cameraIndex;
    private int cameraIndex;
    
    //fade panel
    public TextMeshPro blackPanel;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraIndex = 0;

        if (camerasList.Count > 0)
        {
            SwitchCamera(camerasList[0]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //if you click a specific thing
        //change the camera

        if (Input.GetKey(KeyCode.E))
        {
            SwitchCamera(camerasList[1]);
            Debug.Log("function called");
            
        }

        if (Input.GetKey(KeyCode.Q))
        {
            /*//save the current color by storing it into a local variable
            Color currentColor = blackPanel.color;
            //set the new color
            currentColor.a = 0;
            blackPanel.color = currentColor;*/
            
            Color colorLerp = new Color(0, 0, 0, 0);
            Color lerpedColor = Color.Lerp(Color.black, colorLerp, Time.deltaTime * 2);
            blackPanel.color = lerpedColor;
        }
    }
    
    void SwitchCamera(Camera cam)
    {
        //for each camera in the list
        foreach (Camera camera in camerasList)
        {
            //turn them off
            camera.enabled = false;
        }
        
        //camerasList[cameraIndex].gameObject.SetActive(true);
        cam.enabled = true;
        Debug.Log("cam enabled true");
    }

    private void OnMouseDown()
    {
        
    }
}
