using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giris : MonoBehaviour
{
    float zaman = 0;
    public GameObject oklar;
    void Start()
    {
        
    }

    
    void Update()
    {
        zaman += Time.deltaTime;
       
        if (zaman >= 8)
        {
            this.gameObject.SetActive(false);
            oklar.SetActive(true);
        }
    }
}
