using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class küpcük : MonoBehaviour
{
    public GameObject DEGECEK;
    public TextMeshProUGUI tex;
    float zaman = 00;
    public TextMeshProUGUI acılacak_txt;
    public Button acılacak_btn,kapanacak_btn;
    private void OnMouseDrag()
    {
        if (transform.position.y > -3.60 && transform.position.y < 5.45f)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 11.56f;
            transform.position = pos;
        }
      

        if (transform.position.y <= -3.60)
        {
            transform.position = new Vector3(transform.position.x, -3.59f, transform.position.z);
        }
        if (transform.position.y >= 5.45)
        {
            transform.position = new Vector3(transform.position.x,5.44f, transform.position.z);
        }
       
    }
    
    void Update()
    {
        if (Input.touchCount==2)
        {
            DEGECEK.SetActive(true);
        }
        zaman += Time.deltaTime; 
        if (zaman >= 7f)
        {
            tex.gameObject.SetActive(false);
            zaman = 0;
        }
        print(zaman);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == DEGECEK)
        {
            
            SceneManager.LoadScene(1);
         
        }
    }
    public void calıstır()
    {
        
        if (!tex.gameObject.activeSelf)
        {
            tex.gameObject.SetActive(true);
           
        }
        
        
    }
}
