using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class karelialankontrol : MonoBehaviour
{
    public GameObject [] d�secekler;
    
    void Start()
    {
        
    }

    float zaman;
    void Update()
    {
        
        if (hile.gameObject.activeSelf)
        {
            zaman += Time.deltaTime;

            if (zaman >= 3)
            {
                hile.gameObject.SetActive(false);
                zaman = 0;
            }
        }
    }
    public TextMeshProUGUI hile;
    
    public void karleridusur()
    {
      
            d�secekler = GameObject.FindGameObjectsWithTag("d�sen5");
            foreach (var i in d�secekler)
            {
                i.SetActive(false);
            }
        
    }
    public void hilee()
    {
        hile.gameObject.SetActive(true);
      

    }
}
