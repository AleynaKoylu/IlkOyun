using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelkup2 : MonoBehaviour
{
    void Start()
    {
        eski_x = transform.position.x;
        
    }

    public float x;
    public float eski_x;
    float yenix;
    

    void Update()
    {

        if (transform.position.x <= eski_x)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(x, transform.position.y, transform.position.z), 0.01f);
            yenix = transform.position.x;
        }
            
       
       
            if (transform.position.x <= x+0.15f)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(yenix, transform.position.y, transform.position.z), 0.01f);
            }
        

    }
}
