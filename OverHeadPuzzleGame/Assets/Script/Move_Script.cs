using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Script : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;
    public bool red;
   
    void Update()
    {
        if (Input.GetButtonDown("B Button"))
        {

            red = !red;

        }
        if (Input.GetButtonDown("A Button") || Input.GetButtonDown("Y Button") || Input.GetButtonDown("X Button"))
        {
            red = false;
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
        
  
        
    }
   





}
