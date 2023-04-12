using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraakontrol : MonoBehaviour
{
    public GameObject takip_edilecek;
    float mesafe;
    
    void Start()
    {
        mesafe =transform.position.z-takip_edilecek.transform.position.z;
       
    }

    
    void Update()
    {
        transform.position =new Vector3(transform.position.x,transform.position.y, mesafe+takip_edilecek.transform.position.z);
        
     
    }
}
