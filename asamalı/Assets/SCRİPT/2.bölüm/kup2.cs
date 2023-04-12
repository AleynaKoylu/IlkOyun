using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class kup2 : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
        kontrol();
       
    }
    public TextMeshProUGUI yanlýs;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("degecekyer"))
        {
            ekranyukleme(0);
        }
        if (other.gameObject.CompareTag("yanlýs"))
        {
            yanlýs.gameObject.SetActive(true);
            
           
        }
        if (other.gameObject.CompareTag("dogru"))
        {
            ekranyukleme(3);
        }
    }
    void ekranyukleme(int sayi)
    {
        SceneManager.LoadScene(sayi);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("yanlýs"))
        {
            yanlýs.gameObject.SetActive(false);


        }
    }
    void kontrol()
    {
        if (Input.touchCount > 0)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            if(Physics.Raycast(ray,out hit,Mathf.Infinity,1<<6))
            {
                transform.position = hit.point;
            }
        }
        
       

    }
}
