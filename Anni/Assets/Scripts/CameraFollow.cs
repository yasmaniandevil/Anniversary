using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed;
    public Vector3 offset;

    public Transform letter;
    OnLetters onLettersScript;
    
    //zoom in var
    public float targetFOV;
    public float defaultFOV;
    public float zoomSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //on start make the target the player
        SwitchTarget(player);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        /*if(player != null)
        {

            //calculates the target position the camera should move to
            //creates a new position that considers where the camera is relative to player
            Vector3 desiredPos = player.position + offset;
            //lerp smoothly interpolate btwn the current position and the desired position
            Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
            transform.position = smoothPos;
        }*/

        
    }

    //function that just switches the target
    //then that function needs to update the camera 
    public void SwitchTarget(Transform target)
    {
        if (target != null)
        {
            Vector3 desiredPos = target.transform.position + offset;
            Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
            transform.position = smoothPos;

        }
    }
    
    //i need to actually do something with FOV
    IEnumerator ZoomIn(Camera cam, float targetFOV, float duration)
    {
        float startFOV = cam.fieldOfView;
        float elapsedTime = 0;
        elapsedTime += Time.deltaTime;
        while (elapsedTime < duration)
        {
            cam.fieldOfView = Mathf.Lerp(startFOV, targetFOV, elapsedTime / duration);
            yield return null;
        }

        cam.fieldOfView = targetFOV;

        elapsedTime = 0;
        yield return null;
    }

}
