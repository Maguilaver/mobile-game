using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controlador : MonoBehaviour
{
    //Atualizar moedas durante o jogo
    public Text textoMoedas; //texto moedas obtidas durante o jogo

    public int Moedas;

    public int TotalMoedas;

    public Text textoMoedasTotais;

    //Atualizar pontua��o durante o jogo
    public Text textoPontos;

    public int totalPontos;

    public static Controlador acesso; // acessar essa clase por outro script

    //Atualizar Falhas

    public Text textoFalhas;

    public int totalFalhas;

    //Painel perder

    public GameObject painelPerder;

    // Texto Pontua��o final e moedas finais

    public Text pontosFinais;

    public Text moedasFinais;

    //Bot�o pause

    public GameObject botaoPause;

    //Salvar o jogo

    public bool save;


    //musicas e efeitos sonoros

    //perder
    public AudioSource Sons;
    public AudioClip somPerder;

    //musica gameplay minigame

    public AudioSource musicaGameplay;
   
     
    // Start is called before the first frame update
    void Start()
    {
        //Time.timeScale = 0f;

        acesso = this; // criar uma variavel estatica e atribuir o valor dela ao proprio script
                       // assim, quando eu chamar essa variavel de outro script consigo acessar tudo dele que n�o seja private

        Moedas = 0;

        save = false; //save recebe falso, pois no inicio do jogo n�o queremos que salve.
    }

    private void Update()
    {
       
    }


    public void AtualizarMoedas()
    {
        textoMoedas.text = Moedas.ToString();
    }
   public void AtualizarPontos()
    {
        textoPontos.text = totalPontos.ToString().PadLeft(4,'0'); //pegamos o texto do componente e depois convertemos o valor total (que � int) para string
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
        save = true; //ao acabar o jogo, ele salvar� as informa��es

        Time.timeScale = 0f;

        painelPerder.SetActive(true);

        //sons e musica
        Sons.PlayOneShot(somPerder);

        musicaGameplay.Pause();

        //mostrar pontua��o na tela de perde
        pontosFinais.text = "Pontua��o  " + totalPontos.ToString();

        //mostrar moedas na tela de perder

        TotalMoedas = PlayerPrefs.GetInt("totalScore");
        //usamos GetInt no PlayerPref para pegar valores salvos

        //Moedas totais presentes com o player
        TotalMoedas = TotalMoedas + Moedas;

        textoMoedasTotais.text = "Moedas finais " + TotalMoedas.ToString();

        moedasFinais.text = "Moedas obtidas " + Moedas.ToString();
        

        salvarMoedas(); //salvar

        //desativar interfaces 
        textoPontos.gameObject.SetActive(false);
        textoFalhas.gameObject.SetActive(false);
        botaoPause.SetActive(false);
        textoMoedas.gameObject.SetActive(false);


    }

    public void TentarNovamente()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("DEBUG2");
    }

    private void salvarMoedas()
    {
        if (save == true)
        {
            PlayerPrefs.SetInt("totalScore", TotalMoedas);
            //no PlayerPref, usa-se Setin para salvar informa�oes
            PlayerPrefs.Save();
        }
    }


    public static void DeleteAll()
    {

        PlayerPrefs.DeleteAll();

    }
}
