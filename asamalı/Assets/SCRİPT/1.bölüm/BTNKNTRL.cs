using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BTNKNTRL : MonoBehaviour
{
    public GameObject acılacakküp;
    public Button gelecekbuton;
    
    public TextMeshProUGUI gidecektext;
    public Button gidecekbutton;
    public void btnkntrl()
    {
       acılacakküp.SetActive(true);
        gelecekbuton.gameObject.SetActive(true);
        
        gidecektext.gameObject.SetActive(false);
        gidecekbutton.gameObject.SetActive(false);
    }
}
