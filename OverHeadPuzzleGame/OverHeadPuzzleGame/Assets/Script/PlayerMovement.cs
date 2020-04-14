using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float movementSpeed;
    public float gravity = -9.81f;

    public GameObject camera;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;

    void Update()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        float x = Input.GetAxis("MoveHorizontal");
        float z = Input.GetAxis("MoveVertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * movementSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

       // if (playerPlane.Raycast(ray, out hitDist))
        {
          //  Vector3 targetPoint = ray.GetPoint(hitDist);
            
             
           // Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
           // targetRotation.x = 0;
           // targetRotation.z = 0;
            //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 7f * Time.deltaTime);

        }
        
        
    }
}   

    