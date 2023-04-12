using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AXE : MonoBehaviour
{
   Vector3 yön;
    void Start()
    {
       
       
    }

    float zaman = 0;
    int zd = 0;
    public int z;
    void Update()
    {
        zaman += Time.deltaTime;
        zd = (int)zaman;
        if (zd ==0)
        {
            transform.Rotate(new Vector3(0, 0,-z) * Time.deltaTime);
        }
        else if (zd == 1)
        {
            transform.Rotate(new Vector3(0, 0,z) * Time.deltaTime);
        }
        else if (zd == 2)
        {
            zaman = 0;
        }
        
       
    }
   
    private void OnTriggerEnter(Collider other)
    {
        
    }
}
