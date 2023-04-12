using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class kontrol : MonoBehaviour
{
    int sayac = 0;
    public TextMeshProUGUI açýlýþ;
    public Button buton;

 
    
    void Update()
    {
       
        
        if (sayac >= 0 )
        {
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    açýlýþ.gameObject.SetActive(true);
                    sayac++;
                    print(sayac);
                    if (sayac == 2)
                    {
                        buton.gameObject.SetActive(true);
                        sayac = -1;
                    }
                }
            }
            
          /*  if (Input.GetKeyDown(KeyCode.A))
            {

                açýlýþ.gameObject.SetActive(true);
                sayac++;
                print(sayac);
                if (sayac == 2)
                {
                    buton.gameObject.SetActive(true);
                    sayac = -1;
                }

            }*/
        }

    }
    public void ekrandegistirme()
    {
        SceneManager.LoadScene(1);
    }
}
