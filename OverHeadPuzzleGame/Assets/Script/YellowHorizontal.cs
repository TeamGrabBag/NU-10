using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowHorizontal : MonoBehaviour
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
        if (Input.GetButtonDown("A Button") || Input.GetButtonDown("B Button") || Input.GetButtonDown("X Button"))
        {
            yellow = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (yellow == true)
        {
            float x = Input.GetAxis("RightHorizontal");



            Vector3 move = -transform.right * x;

            controller.Move(move * speed * Time.deltaTime);

        }
    }





}
