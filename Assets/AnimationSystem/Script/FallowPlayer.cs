using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour
{
    public Transform cameraTarget;
    public float speed = 1000f;
    public Transform lookTarget;

    private void FixedUpdate()
    {
        Vector3 dPos = cameraTarget.position;        
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, speed);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }
}