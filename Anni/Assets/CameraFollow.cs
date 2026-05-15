using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed;
    public Vector3 offset;

<<<<<<< HEAD:Anni/Assets/Scripts/CameraFollow.cs
    public Transform letter;
    OnLetters onLettersScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //on start make the target the player
        SwitchTarget(player);
=======
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
>>>>>>> parent of 09c2b8a (making letter appear):Anni/Assets/CameraFollow.cs
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
<<<<<<< HEAD:Anni/Assets/Scripts/CameraFollow.cs

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
=======
>>>>>>> parent of 09c2b8a (making letter appear):Anni/Assets/CameraFollow.cs
}
