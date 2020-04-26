using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenHorizontal : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;
    public bool green = false;


    void Update()
    {
        if (Input.GetButtonDown("A Button"))
        {
            green = !green;
        }
        if (Input.GetButtonDown("Y Button") || Input.GetButtonDown("B Button") || Input.GetButtonDown("X Button"))
        {
            green = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (green == true)
        {
            float x = Input.GetAxis("RightHorizontal");
            


            Vector3 move = -transform.right * x;

            controller.Move(move * speed * Time.deltaTime);

        }
    }





}
