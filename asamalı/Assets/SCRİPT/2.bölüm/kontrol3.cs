using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol3 : MonoBehaviour
{
    public GameObject kayacak;
    public float hýz;
    public GameObject acýlacakalan;
    public GameObject acýlacakkup;

    void Start()
    {
        
    }

    
    void Update()
    {
        kayacak.transform.Translate(new Vector3(0f, -0.1f, 0f) * Time.deltaTime * hýz);
        if (kayacak.transform.position.y <=-781)
        {
            acýlacakalan.SetActive(true);
            acýlacakkup.SetActive(true);
            kayacak.SetActive(false);
        }

    }
    public void acýlacak()
    {
        acýlacakalan.SetActive(true);
        acýlacakkup.SetActive(true);
        kayacak.SetActive(false);
    }
}
