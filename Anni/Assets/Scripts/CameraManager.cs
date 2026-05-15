using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
    public List <Camera> camerasList = new List<Camera>();
    //private List <int> cameraIndex;
    private int cameraIndex;
    
    //fade panel
    public Image blackPanel;
    
    OnLetters onLetters;
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
            Debug.Log("switch cameras");
            
        }

        if (Input.GetKey(KeyCode.Q))
        {
            ChangePanel();
        }

        if (onLetters.amDragging)
        {
            //SwitchCamera(1);
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

    void ChangePanel()
    {
        //start color is black
        Color startColor = Color.black;
        //end color is transparent
        Color colorLerp = new Color(0, 0, 0, 0);
        Color lerpedColor = Color.Lerp(startColor, colorLerp, Time.deltaTime * 10);
        blackPanel.color = lerpedColor;
        //lerpedColor = blackPanel.color;
        Debug.Log("color panel");
    }

    
}
