using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class KONTROLCÜ : MonoBehaviour
{
    Color beyaz = new Color(1, 1, 1, 1);
    public List<Image> kalpler = new List<Image>();
    Image resim;
    GameObject kare;
    public TextMeshProUGUI sayıtutucu;
    public GameObject silinecek;
    public GameObject eklenecek;
    public Camera camera_kaldırılıcak;
    


    void Start()
    {
        kare = GameObject.FindGameObjectWithTag("kare");
        resim = kare.GetComponentInChildren<Image>();
        
    }

   
    void Update()
    {
        if (kalpler.Count >= 19)
        {
            camera_kaldırılıcak.transform.SetParent(silinecek.transform);
            Destroy(silinecek);
            eklenecek.SetActive(true);
            
           

        }
       
    }
   
    public void kalpeklee()
    {
       
            kalpler.Add(resim);
        
    }
    public void kalpsayısı()
    {
        sayıtutucu.text = (19 - kalpler.Count).ToString();
        
        
    }
   
}
