using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
public Transform player;
public float distance = 3;
public float height = 2;
public float shoulderOffset = 2;
public bool switchShoulder;
public float smoothTime = 0.25f;
Vector3 lookTarget;
Vector3 lookTargetVelocity;
Vector3 currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
    Vector3 target = player.position + (-player.transform.forward * distance);
    Vector3 verticalPosition = Vector3.up * height;
    Vector3 shoulderPosition = switchShoulder ? transform.right * -shoulderOffset : transform.right * shoulderOffset;
    transform.position = Vector3.SmoothDamp(transform.position, target + shoulderPosition + verticalPosition, ref currentVelocity, smoothTime);
    lookTarget = Vector3.SmoothDamp(lookTarget, player.position + verticalPosition + shoulderPosition, ref lookTargetVelocity, smoothTime);
    transform.LookAt(lookTarget);

   }
}
/*
 *public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
 
    void Update ()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
*/
