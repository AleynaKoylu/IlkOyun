using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelkup : MonoBehaviour
{
    public GameObject OYUNCU;
    Vector3 eski_pos;
    Vector3 mesafe;
    public Animator anim;
    public RuntimeAnimatorController animm;
    void Start()
    {
        eski_pos = transform.position;
    }

   

    void Update()
    {
        if (transform.position.z <= 42f)
        {
            if (transform.position.z < OYUNCU.transform.position.z)
            {
                transform.position = new Vector3(eski_pos.x, eski_pos.y, eski_pos.z + 9f);
                eski_pos = transform.position;
            }
            mesafe = transform.position - OYUNCU.transform.position;
            if (mesafe.z <= 3.5f)
            {
                anim.runtimeAnimatorController = animm;
            }

        }
      
       
       
        
    }
}
