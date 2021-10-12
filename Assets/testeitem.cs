using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeitem : MonoBehaviour
{
    public GameObject Quadrado;
    public static  int quadrado;
    // Start is called before the first frame update
    void Start()
    {
        quadrado = PlayerPrefs.GetInt("quadrado", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(quadrado == 1)
        {
            Quadrado.SetActive(false);
        }

        if(quadrado == 2)
        {
            Quadrado.SetActive(true);

        }
    }
}
