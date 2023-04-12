using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class puzzlekontrol : MonoBehaviour
{
    GameObject yer;
    SpriteRenderer sr;
    SpriteRenderer sr2;
    public List<GameObject> puzellar = new List<GameObject>();
    float zaman=1;
    int dönzmn;
    public Image resim;
    
    public TextMeshProUGUI zamann;
    bool zamanaktifmi =true;
    public TextMeshProUGUI uyarý;
    bool puzzeltamamlandýmý = false;
    public TextMeshProUGUI zamanuyarý; float zmn = 0;
    
    void Update()
    {
        zmn += Time.deltaTime;
        if (zmn >= 5)
        {
            zamanuyarý.gameObject.SetActive(false);
            zmn = 0;
        }
        
        dönzmn = (int)zaman;
        zamann.text = dönzmn.ToString();
        zamanolaylarý();
        puzzleicin();
        uyarýacma();

          
    }
    void uyarýacma()
    {
        if (resim.gameObject.activeSelf==false)
        {
            if (dönzmn <= 15)
            {
                if (dönzmn % 2 == 0)
                {
                    uyarý.gameObject.SetActive(true);
                }
                else
                {
                    uyarý.gameObject.SetActive(false);
                }
                
            }
            else
            {
                uyarý.gameObject.SetActive(false);
            }
        }
    }
   void zamanolaylarý()
    {
        if (!puzzeltamamlandýmý)
        {
            if (zamanaktifmi)
            {
                zaman += Time.deltaTime;
                if (zaman >= 5)
                {
                    resim.gameObject.SetActive(false);
                    zaman = 60;

                    zamanaktifmi = false;

                }

            }
            else
            {
                zaman -= Time.deltaTime;
            }
            if (dönzmn <= 30)
            {


                zamann.color = Color.red;


                
            }
            if (dönzmn == 59)
            {
                zamann.color = new Color(0.13f, 1f, 0f);
            }
            if (dönzmn ==0)
            {
                SceneManager.LoadScene(0);
            }
        }
     
    }
    void puzzleicin()
    {
        for (int i = 0; i < puzellar.Count; i++)
        {
            yer = GameObject.Find(puzellar[i].name + "(1)");
            sr = puzellar[i].GetComponent<SpriteRenderer>();
            sr2 = yer.GetComponent<SpriteRenderer>();

            if (puzellar[i].transform.position.x >= yer.transform.position.x - 0.30f && puzellar[i].transform.position.x <= yer.transform.position.x + 0.30f)
            {
                if (puzellar[i].transform.position.y >= yer.transform.position.y - 0.30f && puzellar[i].transform.position.y <= yer.transform.position.y + 0.30f)
                {
                    GameObject silinecek = puzellar[i];
                    puzellar[i].transform.position = yer.transform.position;
                    puzellar.RemoveAt(i);
                    Destroy(silinecek);
                    sr2.color = Color.white;

                }

            }
        }
        if (puzellar.Count <= 0)
        {
           
            puzzeltamamlandýmý=true; 
            SceneManager.LoadScene(4);

        }
    }
    public void uyarma()
    {
        
        zamanuyarý.gameObject.SetActive(true);
       

    }
}
