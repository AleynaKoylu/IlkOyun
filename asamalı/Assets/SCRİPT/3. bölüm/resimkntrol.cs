using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resimkntrol : MonoBehaviour
{

    private void OnMouseDrag()
    {
        Vector3 pozisyon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = transform.position.z;
        transform.position = pozisyon;

    }
}
