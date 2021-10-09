using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Controlador : MonoBehaviour
{

    //Atualizar pontos

    [SerializeField]
    private Text textoPontos;

    [SerializeField]
    private int contPontos;




    // Start is called before the first frame update
    void Start()
    {
        contPontos = 8;
        textoPontos.text += contPontos;

    }

    // Update is called once per frame
    void Update()
    {

    }
}