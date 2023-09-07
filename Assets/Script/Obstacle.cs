using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private void OnCollissionEnter(Collision collision)
    {
         if (collision.rigidbody.CompareTag("Player"))
        {
            Debug.Log(message: "CollisionEnter: " + collision.rigidbody.name);
        }
         else
        {
            var normal:Vector3 = 
        }
       
    }

    private void OnCollissionExit(Collision collision)
    { 
        if (collision.rigidbody.CompareTag("Player"))
        {
            Debug.Log(message:"CollisionExit: " + collision.rigidbody.name);
        }
    }
    private void OnCollissionStay(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Player"))
        { 
            Debug.Log(message: "CollisionStay: " + collision.rigidbody.name);
        }
    }




}
