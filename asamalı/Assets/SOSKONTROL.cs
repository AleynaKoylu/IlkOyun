using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class SOSKONTROL : MonoBehaviour
{
    
    Image resim;
    Color beyaz = new Color(1, 1, 1, 1);
    Image bomba;
    public Image panel;
    BoxCollider bc;
    KONTROLC� kONTROLC�;
    GameObject kntrl;
    GameObject panelt�klama;
    
 
    private void OnMouseDown()
    {
         
            resim.color = beyaz;
        if (resim.CompareTag("kalp") && resim.color == beyaz)
        {
            kONTROLC�.kalpeklee();
           
            bc.enabled = false;
            kONTROLC�.kalpsay�s�();

        }
        if (resim.CompareTag("bomba") && resim.color == beyaz)
            {
                
                panel.gameObject.SetActive(true);
           
            }
           
       
    }
    void t�klamaengelleme()
    {
        if (panelt�klama.activeSelf ==false)
        {

            bc.enabled = false;
        }
        else
        {
            bc.enabled = true;
        }
        
    }
    void Start()
    {

        kntrl = GameObject.FindGameObjectWithTag("kntrl");
        panelt�klama = GameObject.FindGameObjectWithTag("panelt�klanmaz");
        resim = GetComponentInChildren<Image>();
        kONTROLC� = kntrl.GetComponent<KONTROLC�>();
        bc = GetComponent<BoxCollider>();
    }

   
    void Update()
    {
        oyundurdurma();
       
    }
    void oyundurdurma()
    {
        if (panel.gameObject.activeSelf)
        {
           
            bc.enabled = false;
        }
    }
  
    
    
}
