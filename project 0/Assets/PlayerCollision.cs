using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
   void OnCollisionEnter(Collision colliderInfo)
   {
       if(colliderInfo.collider.tag == "Enemy")
       {
             movement.enabled = false;  
       }
    
   } 
 
}
