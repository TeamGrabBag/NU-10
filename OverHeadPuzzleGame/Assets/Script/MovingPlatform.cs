using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject PlayerHolder;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == PlayerHolder)
        {
            PlayerHolder.transform.parent = transform;
        }
    }
    private void OntriggerExit(Collider other)
    {
        if (other.gameObject == PlayerHolder)
        {
            PlayerHolder.transform.parent = null;
        }
    }
}
