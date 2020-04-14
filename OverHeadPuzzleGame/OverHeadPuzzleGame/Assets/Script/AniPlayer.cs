using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniPlayer : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("vertical", Input.GetAxis("MoveVertical"));
        anim.SetFloat("horizontal", Input.GetAxis("MoveHorizontal"));
    }
        
         
        
    
}
