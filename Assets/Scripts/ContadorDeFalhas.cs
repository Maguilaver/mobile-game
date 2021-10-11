using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorDeFalhas : MonoBehaviour
{
    [SerializeField]
    private int falhas;

    //Pensar no slow update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ingredientes")
        {
            Controlador.acesso.totalFalhas = falhas++ + 1;
            Controlador.acesso.AtualizarFalhas();
            Destroy(GameObject.FindWithTag("ingredientes"));

            //checagem
            if (Controlador.acesso.totalFalhas == 9)
            {
                Controlador.acesso.Perder();
            }

           
        }


        if (collision.gameObject.tag == "Animais")
        {
            Destroy(GameObject.FindWithTag("Animais"));
        }
    }

}
