using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapsüller : MonoBehaviour
{
    
    public GameObject duvar;
    public float x;
    public float z;
    void Start()
    {
        
    }

    private void OnMouseDrag()
    {
        Vector3 dönüs = new Vector3(x, 0f, z);
        
        duvar.transform.Rotate(dönüs*Time.deltaTime);
    }
    void Update()
    {
      
       
    }

   
}
