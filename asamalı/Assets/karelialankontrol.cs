using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class karelialankontrol : MonoBehaviour
{
    public GameObject [] düsecekler;
    
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
      
            düsecekler = GameObject.FindGameObjectsWithTag("düsen5");
            foreach (var i in düsecekler)
            {
                i.SetActive(false);
            }
        
    }
    public void hilee()
    {
        hile.gameObject.SetActive(true);
      

    }
}
