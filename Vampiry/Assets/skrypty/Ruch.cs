using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruch : MonoBehaviour
{
    public Rigidbody rb;
    public float xforce = 100f;
    public float jump_force = 100f;
    public float zforce = 100f;
    
    void Move()
    {
        if(Input.GetKey("d"))
        {
            rb.AddForce(xforce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-xforce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("space"))
        {
            rb.AddForce(0,jump_force * Time.deltaTime ,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("w"))
        {
             rb.AddForce( 0,0,zforce * Time.deltaTime, ForceMode.VelocityChange);
        }
         if(Input.GetKey("s"))
        {
             rb.AddForce( 0,0,-zforce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
    void FixedUpdate()
    {
        Move();
    }
}
