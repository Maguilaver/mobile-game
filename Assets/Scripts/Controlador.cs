using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Controlador : MonoBehaviour
{

    //Atualizar pontuação
    public Text textoPontos;

    public int totalPontos;

    public static Controlador acesso; // acessar essa clase por outro script

    //Atualizar Fahas

    public Text textoFalhas;

    public int totalFalhas;


    // Start is called before the first frame update
    void Start()
    {

        acesso = this; // criar uma variavel estatica e atribuir o valor dela ao proprio script
                       // assim, quando eu chamar essa variavel de outro script consigo acessar tudo dele que não seja private
      
    }

   public void AtualizarPontos()
    {
        textoPontos.text = totalPontos.ToString().PadLeft(4,'0'); //pegamos o texto do componente e depois convertemos o valor total (que é int) para string
    }                                             // assim, igualamos o texto da UI com a variavel dos pontos totais

    public void AtualizarFalhas()
    {
        textoFalhas.text = totalFalhas.ToString() + "/9";
    }
}
