using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vektöryön : MonoBehaviour
{
    public GameObject vektor_sag, vektor_sol;
    bool sonageldimi = false;
    public Camera camm;
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sonyer"))
        {
            sonageldimi = true;
        }
    }
        void Update()
    {
        if (sonageldimi == true)
        {
            transform.Translate(new Vector3(0f, 0f, 2.5f * Time.deltaTime));
        }
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began)
            {
                Ray ray = camm.ScreenPointToRay(t.position);
                RaycastHit hit;
                int layermask = 1 << 7;
                
                if (Physics.Raycast(ray,out hit,Mathf.Infinity, layermask))
                {
                    transform.position = hit.point;
                }
            }
           
        }
      
       
    }
}
