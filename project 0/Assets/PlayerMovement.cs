using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
      public float sideforce = 500f;
        public float jump = 300f;
   

    // Update is called once per frame
    // use fixed update wile using physics 
    void FixedUpdate()
    {
        rb.AddForce(0,0,4000*Time.deltaTime);

        if(Input.GetKey("d"))
        {
             rb.AddForce( sideforce*Time.deltaTime,0, 0, ForceMode.VelocityChange);  //forcemode??
        }
        if(Input.GetKey("a"))
        {
             rb.AddForce(-sideforce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //jump
         if(Input.GetKey("w"))
        {
             rb.AddForce(0, jump*Time.deltaTime ,0, ForceMode.VelocityChange);
        }
    }
}
