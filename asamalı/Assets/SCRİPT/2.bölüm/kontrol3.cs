using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol3 : MonoBehaviour
{
    public GameObject kayacak;
    public float h�z;
    public GameObject ac�lacakalan;
    public GameObject ac�lacakkup;

    void Start()
    {
        
    }

    
    void Update()
    {
        kayacak.transform.Translate(new Vector3(0f, -0.1f, 0f) * Time.deltaTime * h�z);
        if (kayacak.transform.position.y <=-781)
        {
            ac�lacakalan.SetActive(true);
            ac�lacakkup.SetActive(true);
            kayacak.SetActive(false);
        }

    }
    public void ac�lacak()
    {
        ac�lacakalan.SetActive(true);
        ac�lacakkup.SetActive(true);
        kayacak.SetActive(false);
    }
}
