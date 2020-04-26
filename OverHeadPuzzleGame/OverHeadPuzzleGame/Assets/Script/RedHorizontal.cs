using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHorizontal : MonoBehaviour
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
            


            Vector3 move = -transform.right * x;

            controller.Move(move * speed * Time.deltaTime);

        }



    }






}
