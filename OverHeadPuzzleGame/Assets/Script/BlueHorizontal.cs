using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueHorizontal : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;
    public bool blue;


    void Update()
    {

        if (Input.GetButtonDown("X Button"))
        {
            blue = !blue;
        }
        if (Input.GetButtonDown("A Button") || Input.GetButtonDown("B Button") || Input.GetButtonDown("Y Button"))
        {
            blue = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (blue == true)
        {
            float x = Input.GetAxis("RightHorizontal");
            


            Vector3 move = -transform.right * x;

            controller.Move(move * speed * Time.deltaTime);

        }
    }





}
