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
<<<<<<< HEAD:Anni/Assets/Scripts/CameraManager.cs
    private Image blackPanel;
=======
    public TextMeshPro blackPanel;
    
>>>>>>> parent of 8a2949f (added car and fixing movement for it):Anni/Assets/CameraManager.cs
    
    OnLetters onLetters;
    CameraFollow cameraFollowScript;

    public Camera cameraFollow;

   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraIndex = 0;

        if (camerasList.Count > 0)
        {
            SwitchCamera(camerasList[0]);
        }

        cameraFollowScript = GetComponent<CameraFollow>();

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
<<<<<<< HEAD:Anni/Assets/Scripts/CameraManager.cs
            //ChangePanel();
        }

        if (onLetters.amDragging)
        {
            //onLetters.mainCam = cameraFollow;
=======
            /*//save the current color by storing it into a local variable
            Color currentColor = blackPanel.color;
            //set the new color
            currentColor.a = 0;
            blackPanel.color = currentColor;*/
            
            Color colorLerp = new Color(0, 0, 0, 0);
            Color lerpedColor = Color.Lerp(Color.black, colorLerp, Time.deltaTime * 2);
            blackPanel.color = lerpedColor;
>>>>>>> parent of 8a2949f (added car and fixing movement for it):Anni/Assets/CameraManager.cs
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

<<<<<<< HEAD:Anni/Assets/Scripts/CameraManager.cs
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

    
=======
    private void OnMouseDown()
    {
        
    }
>>>>>>> parent of 8a2949f (added car and fixing movement for it):Anni/Assets/CameraManager.cs
}
