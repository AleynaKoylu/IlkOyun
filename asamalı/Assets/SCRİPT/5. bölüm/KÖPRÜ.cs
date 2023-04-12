using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KÖPRÜ : MonoBehaviour
{
    Rigidbody rb;
    bool sagagitsin, solagitsin;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
       
    }
    public GameObject yol1;
    public GameObject yol2;
    void Update()
    {

        if (sagagitsin ==true)
        {
            transform.Translate(new Vector3(0, 0, -5f)*Time.deltaTime);
        }
        if (solagitsin == true)
        {
            transform.Translate(new Vector3(0, 0, 5f)*Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("deneme"))
        {
            solagitsin = false;
            sagagitsin = true;
            print("evt");

            //rb.AddForce(new Vector3 (0, 0, -500f )) ;
        }
        if (collision.gameObject.CompareTag("deneme2"))
        {
            solagitsin = true;
            sagagitsin = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }


}
