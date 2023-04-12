using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ödül : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Rotate(new Vector3(15f, 0f, 0f) * Time.deltaTime);
    }
  
}
