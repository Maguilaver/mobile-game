using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controlador : MonoBehaviour
{

    //Atualizar pontuação durante o jogo
    public Text textoPontos;

    public int totalPontos;

    public static Controlador acesso; // acessar essa clase por outro script

    //Atualizar Fahas

    public Text textoFalhas;

    public int totalFalhas;

    //Painel perder

    public GameObject painelPerder;

    // Texto Pontuação final

    public Text pontosFinais;

    //Botão pause

    public GameObject botaoPause;

     
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


    public void Pausar()
    {
        Time.timeScale = 0f; //"congela" o tempo do jogo
    }

    public void Retomar()
    {
        Time.timeScale = 1f;
    }

    public void Perder()
    {
        Time.timeScale = 0f;

        painelPerder.SetActive(true);

        //mostrar pontuação na tela de perder
        pontosFinais.text = "Pontuação  " + totalPontos.ToString();

        //desativar interfaces 
        textoPontos.gameObject.SetActive(false);
        textoFalhas.gameObject.SetActive(false);
        botaoPause.SetActive(false);
    }

    public void TentarNovamente()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("DEBUG2");
    }
}
