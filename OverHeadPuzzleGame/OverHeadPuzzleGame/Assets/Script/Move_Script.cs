using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Script : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;
    public bool red;
    public bool blue;
    public bool green = false;
    public bool yellow;
    void Update()
    {
        if (Input.GetButtonDown("B Button"))
        {
            ClearSelection();
            red = !red;
            
        }
        
        if (Input.GetButtonDown("X Button"))
        {
            ClearSelection();
            blue = !blue;
            
        }
        
        if (Input.GetButtonDown("A Button"))
        {
            ClearSelection();
            green = !green;
            
        }
        
        if (Input.GetButtonDown("Y Button"))
        {
        
           ClearSelection();
           yellow = !yellow;
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (red == true)
        {
            float x = Input.GetAxis("RightHorizontal");
            float z = Input.GetAxis("RightVertical");


            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

        }
        
        if (blue == true)
        {
            float x = Input.GetAxis("RightHorizontal");
            float z = Input.GetAxis("RightVertical");


            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

        }
        if (green == true)
        {
            float x = Input.GetAxis("RightHorizontal");
            float z = Input.GetAxis("RightVertical");


            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

        }
        if (yellow == true)
        {
            float x = Input.GetAxis("RightHorizontal");
            float z = Input.GetAxis("RightVertical");


            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

        }
        
    }
    void ClearSelection()
    {
        yellow = false;
        red = false;
        green = false;
        blue = false;
        Debug.Log("Cleared Selection");
    }





}
