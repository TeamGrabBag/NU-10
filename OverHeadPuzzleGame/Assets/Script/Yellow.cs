using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;
    public bool yellow;


    void Update()
    {
        if (Input.GetButtonDown("Y Button"))
        {
            yellow = !yellow;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
            if (yellow == true)
            {
                float x = Input.GetAxis("RightHorizontal");
                float z = Input.GetAxis("RightVertical");


                Vector3 move = transform.right * x + transform.forward * z;

                controller.Move(move * speed * Time.deltaTime);

            }
        }





    }

