using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topklon : MonoBehaviour
{
   
    public List<GameObject> toplar = new List<GameObject>();
   

    void Start()
    {
        
    }

    
    void Update()
    {
       



    }
    public void topengeli()
    {

        foreach (var i in toplar)
        {
            i.SetActive(true);
        }
        /*zaman += Time.deltaTime;
        int fz = (int)zaman;
        print(fz);
        toplar[fz].SetActive(true);
        if (fz >= 5)
        {
            zaman = 0;
        }*/
    }

}
