using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ingredientes : MonoBehaviour
{
    [SerializeField]
    private int valorItem;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            Controlador.acesso.totalPontos += valorItem;
            Controlador.acesso.AtualizarPontos();  

            Destroy(gameObject);

        }
        
    }
}
