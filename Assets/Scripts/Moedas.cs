using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moedas : MonoBehaviour
{

    void Start()
    {
        Controlador.acesso.Moedas = 0;
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Moedas") == true)
        {
            Controlador.acesso.Moedas = Controlador.acesso.Moedas + 1;

            Controlador.acesso.AtualizarMoedas();

            Destroy(collision.gameObject);
        }
    }
}
