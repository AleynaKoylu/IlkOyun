using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OYUNBASLATMA : MonoBehaviour
{
    

    public void oyunbaslatma()
    {
        SceneManager.LoadScene(4);

    }
    public void enbasadon()
    {
        SceneManager.LoadScene(0);
    }
}
