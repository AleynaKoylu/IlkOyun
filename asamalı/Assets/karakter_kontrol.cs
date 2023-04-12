using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class karakter_kontrol : MonoBehaviour
{
    public GameObject oyuncu;
    public Image panel;
    bool hareket_etsin_mi = true;
    karakter_hareket karakter_Hareket;
    public GameObject karakterhareket;
    public RuntimeAnimatorController dur;
    public Animator duur;
    public RuntimeAnimatorController dus;
    public RuntimeAnimatorController sevinc;
    public RuntimeAnimatorController d�sme;
    public GameObject �d�l;
    public GameObject d�secek_Yer;
    float zaman2;
    
    
    void Start()
    {
        karakter_Hareket = karakterhareket.GetComponent<karakter_hareket>();
        
    }
    float zaman;

    public TextMeshProUGUI hile;
    void Update()
    {
        zaman2 += Time.deltaTime;
        
        if (!hareket_etsin_mi)
        {
           
            duur.runtimeAnimatorController = dur;

        }
        if (hareket_etsin_mi)
        {
            karakter_Hareket.hareketkontrol();
        }
        
    }
    public Image yenidenoyna; 
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("balta"))
        {
            panel.gameObject.SetActive(true);
            hareket_etsin_mi = false;
            
        }
        if (collision.gameObject.CompareTag("�lme"))
        {
            panel.gameObject.SetActive(true);
            

        }
        if (collision.gameObject.CompareTag("ac�l�cak_kupler"))
        {
            panel.gameObject.SetActive(true);
            hareket_etsin_mi = false;
        }
        if (collision.gameObject.CompareTag("atestopu"))
        {
            panel.gameObject.SetActive(true);
            hareket_etsin_mi = false;

        }
        if (collision.gameObject.CompareTag("�d�l"))
        {
            �d�l.SetActive(true);
            collision.gameObject.SetActive(false);
            duur.runtimeAnimatorController = sevinc;
            yenidenoyna.gameObject.SetActive(true);
            
        }
        
        
    }
    public Button gerigitme_btn;
    private void OnCollisionExit(Collision collision)
    {
        if (zaman2 >= 1f)
        {
            if (collision.gameObject.CompareTag("yer"))
            {
                if (�d�l.activeSelf == false)
                {
                    gerigitme_btn.interactable = false;
                    d�secek_Yer.GetComponent<Rigidbody>().useGravity = true;
                    duur.runtimeAnimatorController = d�sme;
                }
                

            }
        }
        

    }

}
