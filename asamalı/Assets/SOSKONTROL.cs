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
    KONTROLCÜ kONTROLCÜ;
    GameObject kntrl;
    GameObject paneltýklama;
    
 
    private void OnMouseDown()
    {
         
            resim.color = beyaz;
        if (resim.CompareTag("kalp") && resim.color == beyaz)
        {
            kONTROLCÜ.kalpeklee();
           
            bc.enabled = false;
            kONTROLCÜ.kalpsayýsý();

        }
        if (resim.CompareTag("bomba") && resim.color == beyaz)
            {
                
                panel.gameObject.SetActive(true);
           
            }
           
       
    }
    void týklamaengelleme()
    {
        if (paneltýklama.activeSelf ==false)
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
        paneltýklama = GameObject.FindGameObjectWithTag("paneltýklanmaz");
        resim = GetComponentInChildren<Image>();
        kONTROLCÜ = kntrl.GetComponent<KONTROLCÜ>();
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
