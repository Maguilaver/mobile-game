using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quadrado()
    {
        testeitem.quadrado = 2;
        PlayerPrefs.SetInt("quadrado", testeitem.quadrado);
        PlayerPrefs.Save();
    }
}
