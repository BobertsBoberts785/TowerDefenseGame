using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    
    public int movSpeed = 10;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey("d"))
        {
            this.transform.position += new Vector3(0.001f * movSpeed, 0, 0);
        }

        if(Input.GetKey("a"))
        {
            this.transform.position -= new Vector3(0.001f * movSpeed, 0, 0);
        }

        if(Input.GetKey("w"))
        {
            this.transform.position += new Vector3(0, 0, 0.001f * movSpeed);
        }

        if(Input.GetKey("s"))
        {
            this.transform.position -= new Vector3(0, 0, 0.001f * movSpeed);
        }
    }
}
