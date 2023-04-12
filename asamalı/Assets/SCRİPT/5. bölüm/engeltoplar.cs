using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engeltoplar : MonoBehaviour
{
    Vector3 eskipos;
    void Start()
    {
        eskipos = transform.position;
    }


    float zaman = 0;
    int dnzmn;
    void Update()
    {
        

        if (gameObject.activeSelf)
        {
            zaman += Time.deltaTime;
            dnzmn = (int)zaman;
            if (dnzmn == 5)
            {
                transform.position = eskipos;
                gameObject.SetActive(false);
                zaman = 0;
            }

        }
    }
}
