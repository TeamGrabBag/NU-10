using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;
    public bool blue;
    private RedScript redScript;
    private GreenScript greenScript;
    private YellowScript yellowScript;

    void Update()
    {
        redScript = GameObject.Find ("")
        if (Input.GetButtonDown("X Button"))
        {
            blue = !blue;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

            if (blue == true)
            {
                float x = Input.GetAxis("RightHorizontal");
                float z = Input.GetAxis("RightVertical");


                Vector3 move = transform.right * x + transform.forward * z;

                controller.Move(move * speed * Time.deltaTime);

            }
        }





    }

