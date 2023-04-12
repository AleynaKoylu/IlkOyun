using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planekontrol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    public List<GameObject> klonlar = new List<GameObject>();
    void Update()
    {
        
        /*for (int i = 0; i < klonlar.Count; i++)
        {

            transform.Translate(Vector3.forward);
            GameObject klnsil = klonlar[i];
            klonlar.RemoveAt(i);
            Destroy(klnsil);
            break;
        }*/
    }
    void klonlama()
    {
       // GameObject klon = Instantiate(gameObject);
       // klonlar.Add(klon);
        

    }
}
