using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter_hareket : MonoBehaviour
{
    public Animator karakter_animator;
    public GameObject oyuncu;
    void Start()
    {
        
    }

    
    void Update()
    {
        


    }
    public Camera cam1;
    public Camera cam2;
    public void hareketkontrol()
    {
        if (gerigit == false)
        {
            if (Input.touchCount > 0)
            {
                Touch t = Input.GetTouch(0);
                if (t.phase == TouchPhase.Stationary)
                {
                    hareketbasma("durma_kosma");
                }
                if (t.phase == TouchPhase.Moved)
                {

                    if (t.deltaPosition.x > 50)
                    {
                        hareketbasma("saga_kos");
                    }




                    if (t.deltaPosition.x < -50)
                    {
                        hareketbasma("sola_kos");
                    }



                }

                if (t.phase == TouchPhase.Ended)
                {

                    hareketkald�rma("durma_kosma");
                    hareketkald�rma("sola_kos");
                    hareketkald�rma("saga_kos");



                }
            }
        }
           
        
    }
    bool gerigit = false;
    public void gerigitme()
    {
        
                
                hareketbasma("geri_gitme");
        gerigit = true;
        
            


        
    }
    public void gerigitmesin()
    {
       
          
            hareketkald�rma("geri_gitme");
        gerigit = false;

        
    }
    
    public void hareketbasma(string yon)
    {
       
            karakter_animator.SetBool(yon, true);
        
        
            
        
    }
    public void hareketkald�rma(string yon)
    {
        karakter_animator.SetBool(yon, false);
    }
}
