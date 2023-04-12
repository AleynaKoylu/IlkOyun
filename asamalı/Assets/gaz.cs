using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class gaz : MonoBehaviour
{
    public GameObject oyuncu;
   
    public Button btn;
    private void OnMouseDrag()
    {
        Debug.Log("degdi");
        
    }
    void Start()
    {
        
    }

  
    void Update()
    {
          for(int i = 0; i < Input.touchCount; i++)
        {
            Touch t = Input.GetTouch(i);
            
        }
    }
    
}
