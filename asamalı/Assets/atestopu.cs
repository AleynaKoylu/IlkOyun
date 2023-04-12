using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atestopu : MonoBehaviour
{
    bool yeredegdimi = false;
    Vector3 eski_transform;
    void Start()
    {
        eski_transform = gameObject.transform.position;
    }

    public GameObject basadon;
    void Update()
    {
       if(!yeredegdimi){
            transform.Translate(0f, 0, -0.5f * 3*Time.deltaTime);
        }
        if (yeredegdimi)
        {
            zamanarttýr();
        }
        if (transform.position.y <= 5)
        {
            transform.position = basadon.transform.position;
            eski_transform = transform.position;
        }
     }
    float zaman = 0;
   
    private void OnCollisionEnter(Collision cl)
    {
        if (cl.gameObject.CompareTag("yer"))
        {
           
            yeredegdimi = true;
           
        }
        
    }
    public int zamndeger;
     int eklecenkmesafe;
    void zamanarttýr()
    {
        zaman += Time.deltaTime;
        print((int)zaman);
        eklecenkmesafe = Random.Range(1, 4);
        if ((int)zaman >= zamndeger)
        {
            transform.position = new Vector3(Random.Range(-0.18f, 2.27f), eski_transform.y, eski_transform.z + eklecenkmesafe);
            eski_transform = transform.position;
            zaman = 0;
            yeredegdimi = false;
        }
    }
   
}
