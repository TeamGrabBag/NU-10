using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    private Transform currentPlatform;
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "MovingPlatform")
        {
            currentPlatform = other.transform;
            transform.parent = other.transform;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.transform == currentPlatform)
        {
            currentPlatform = null;
            transform.parent = null;
        }
    }
    
}
