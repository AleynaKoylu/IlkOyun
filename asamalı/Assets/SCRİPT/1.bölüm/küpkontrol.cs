using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class küpkontrol : MonoBehaviour
{
    bool dy=false;
    bool dy2=false;
    public GameObject yer;
    public Image yeniden;
    public GameObject kaybolacak;
    public Camera iptal_olacak;
    public Camera calısacak;
    public GameObject acılacak;
    
    void Update()
    {

        yönkontrol();
     

    }
    bool hareketetsinmi=false;

    void yönkontrol()
    {
       
        if (Input.touchCount > 0)
        { Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                hareketetsinmi = true;
            }
            if (t.phase == TouchPhase.Ended)
            {
                hareketetsinmi = false;
            }
            if (t.deltaPosition.x > 100)
            {

            }
        }

        
     

    }
    
    private void OnCollisionEnter(Collision collision)
    {
    
        if (collision.gameObject.CompareTag("düsen5"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject == yer)
        {
         
            yeniden.gameObject.SetActive(true);
            
        }
        if (collision.gameObject.CompareTag("bitis"))
        {
            Destroy(kaybolacak);
            acılacak.SetActive(true);
        }
    }
}
