using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class topontrol : MonoBehaviour
{
   
    Vector3 eskipos,ebat;
    int can = 3,puan = 0;
    public GameObject TOPP, efekt,oyuncu;
    public List<Image> kalpler = new List<Image>(); 
    public topklon tk;
    public TextMeshProUGUI skor, puantopla;
    public Image resim;
    float bitiszaman = 0;
    public bool hareket = false, saga_gitmek = false, sola_gitmek = false, arkaya_gitmek = false, donsunmu = true, hareketetsinmi = true;
    string y�n;
   
    void Start()
    {
        
        eskipos = transform.position;
        ebat = transform.localScale;
    }
    void Update()
    {
        if (transform.position.y <= 2.50f)
        {
            yanma();
        }
        if (!resim.gameObject.activeSelf)
         {

            //d�nme();
            z�plama();
            switch (y�n)
            {
                    case "sa�":
                    if (saga_gitmek == true)
                    {
                    transform.Translate( new Vector3(10f * Time.deltaTime, 0f, 0));
                    }
                    break;
                    case "sol":
                    if (sola_gitmek == true)
                    {
                       
                        transform.Translate(new Vector3(-10f * Time.deltaTime, 0f, 0));
                    }
                    break;
                    case "�n":
                    if (hareket == true)
                    {
                       
                        transform.Translate(new Vector3(0, 0f, 10f * Time.deltaTime));
                    }
                    break;
                    case "arka":
                    if (arkaya_gitmek == true)
                    {
                        
                         transform.Translate(new Vector3(0, 0f, -10f * Time.deltaTime));
                    }
                    break;
            }


        }


    }
    private void OnCollisionStay(Collision cl)
    {
        if (cl.gameObject.CompareTag("bitis"))
        {
            if (puan == 50)
            {
                bitiszaman += Time.deltaTime;
                efekt.SetActive(true);
                if (bitiszaman >= 5)
                {
                    SceneManager.LoadScene(5);
                }
            }
            else
            {
                puantopla.gameObject.SetActive(true);
           
            }

        }
        if (cl.gameObject.CompareTag("kopru"))
        {
            // gameObject.transform.SetParent(cl.gameObject.transform);

            transform.SetParent(cl.gameObject.transform);
            print("degdiikkkk");


        }
    }
    private void OnCollisionEnter(Collision cl)
    {
        if (cl.gameObject.CompareTag("yokus"))
        {
           
            tk.topengeli();
           
            
        }
       
        if (cl.gameObject.CompareTag("toplar"))
        {
            yanma();
        }
        if (cl.gameObject.CompareTag("d�secek"))
        {
            cl.gameObject.GetComponent<Rigidbody>().useGravity = true;


        }

    }
    private void OnCollisionExit(Collision cl)
    {
        if (cl.gameObject.CompareTag("kopru"))
        {
            gameObject.transform.SetParent(TOPP.transform);
            gameObject.transform.localScale = ebat;
        }
        if (cl.gameObject.CompareTag("bitis"))
        {
            puantopla.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("�d�l"))
        {
            other.gameObject.SetActive(false);
            puanartt�r();
            puanal();


        }
        


    }
    void puanartt�r()
    {
        puan += 10;
        skor.text = "Puan: " + puan;
    }
     int puanal()
    {
        return puan;
    }
    void z�plama()
    {
        
        if (Input.touchCount > 0)
        {
            Touch ilkdokunma = Input.GetTouch(0);
            if (ilkdokunma.phase == TouchPhase.Moved)
            {
                float dokunmamesafesi = ilkdokunma.deltaPosition.y;
                float dokunmamesafesix = ilkdokunma.deltaPosition.x;
                 
                if (dokunmamesafesi > 100)
                {
                    
                    gameObject.transform.position =new Vector3(gameObject.transform.position.x, gameObject.transform.position.y+ .4f,gameObject.transform.position.z);
                    
                }
                if (donsunmu == true)
                {
                    if (dokunmamesafesix > 10)
                    {
                        gameObject.transform.Rotate(0f, transform.rotation.y + 100f * Time.deltaTime, 0f, Space.Self);
                    }
                    if (dokunmamesafesix < -10)
                    {
                        gameObject.transform.Rotate(0f, transform.rotation.y - 100f * Time.deltaTime, 0f, Space.Self);
                    }
                }
             
                
            }
        }
    }
    public void durma()
    {
        switch (y�n)
        {
            case "sa�":
                saga_gitmek = false;
                donsunmu = true;
                break;
            case "sol":
                sola_gitmek = false;
                donsunmu = true;
                break;
            case "�n":
                hareket = false;
                donsunmu = true;
                break;
            case "arka":
                arkaya_gitmek = false;
                donsunmu = true;
                break;
        }
    }
    public void saga_gitme()
    {
        saga_gitmek = true;
        y�n = "sa�";
        donsunmu = false;
        
    }
    public void sola_gitme()
    {
        sola_gitmek = true;
        y�n = "sol";
        donsunmu = false;

    }
    public void one_gitme()
    {
        hareket = true;
        y�n = "�n";
        donsunmu = false;

    }
    public void arkaya_gitme()
    {
        arkaya_gitmek = true;
        y�n = "arka";
        donsunmu = false;

    }
    public void yanma()
    {
        gameObject.transform.position = eskipos;
        if (can > 0)
        {
            can--;
            kalpler[can].gameObject.SetActive(false);
            print(can);
        }

        if(can<=0)
        {
            SceneManager.LoadScene(0);
        }
    }
    /*void d�nme()
    {
        if (donsunmu == true)
        {
            if (Input.touchCount > 0)
            {
                Touch sagadon = Input.GetTouch(0);
                if (sagadon.phase == TouchPhase.Stationary)
                {
                    gameObject.transform.Rotate(0f, transform.rotation.y +100f*Time.deltaTime, 0f, Space.Self);
                 
                }

            }
        }*/
       
   // }
    
}
