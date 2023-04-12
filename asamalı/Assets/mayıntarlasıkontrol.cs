using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mayıntarlasıkontrol : MonoBehaviour
{
    public GameObject kalan;
    void Update()
    {
        kapanacakyazi();
    }
    public Image panel;
    float zaman;

    void kapanacakyazi()
    {
        if (panel.gameObject.activeSelf)
        {
            zaman += Time.deltaTime;
            if ((int)zaman >=2 )
            {
               panel.gameObject.SetActive(false);

                zaman = 0;

            }
        }
        if (panel.gameObject.activeSelf == false)
        {
            kalan.SetActive(true);
        }

    }
}
