using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class giriskontrol : MonoBehaviour
{
    public TextMeshProUGUI ekranadokun;
    public TextMeshProUGUI[] textler;
    public GameObject aktiflesecek,kapanacak;
    
    int i = 0;
    void Start()
    {

    }


    void Update()
    {
        if (i > textler.Length)
        {
            aktiflesecek.SetActive(true);
            kapanacak.SetActive(false);
            this.gameObject.SetActive(false);

        }
       
            if (Input.touchCount > 0)
            {
                Touch t = Input.GetTouch(0);

                if (t.phase == TouchPhase.Began)
                {
                    ekranadokun.color = Color.black;
                if (i < textler.Length)
                {
                    textler[i].gameObject.SetActive(true);
                }    
                
                }
                if (t.phase == TouchPhase.Ended)
                {
                    i++;
                }
            
       
        }

        
    }
}
