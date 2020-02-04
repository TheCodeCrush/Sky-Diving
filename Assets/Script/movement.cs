using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Animator Anim;
    public GameObject parachute;
    // Start is called before the first frame update
    void Start()
    {
        Anim = gameObject.GetComponent<Animator> ();    
        
            Anim.SetBool("isLanding",false);   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Anim.SetBool("isWalking", true);
        }
        else if( Input.GetKeyUp (KeyCode.W))
        {
            Anim.SetBool("isWalking",false);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Anim.SetBool("isJumping",true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Anim.SetBool("isJumping",false);
        }

        //joystick
        if(Input.GetButtonDown("Jump")||Input.GetButtonDown("Fire2"))
        {
            Anim.SetBool("isJumping",true);
        }
        else if (Input.GetButtonUp("Jump")||Input.GetButtonUp("Fire2"))
        {
            Anim.SetBool("isJumping",false);
        }

            Debug.Log(PlayerMovement.isGrounded);
        if(!PlayerMovement.isGrounded)
        {
            Anim.SetBool("isFlying",true);

        }
        if(PlayerMovement.isGrounded)
        {
            Anim.SetBool("isFlying",false);
            Anim.SetBool("isWalking",false);
            Anim.SetBool("isLanding",true);
        }
      //Dhruv Parachute
        if(Input.GetButton("Fire1"))
        {
            parachute.SetActive(true);
        }


    }
}