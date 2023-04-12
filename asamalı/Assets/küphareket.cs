using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class küphareket : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    
    void Update()
    {
       
            rb.velocity = Vector3.up;

        
        if (transform.position.y >=-3.419f)
        {
            rb.velocity = Vector3.zero;
        }
    }
}
