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

    //Atualizar pontuação durante o jogo
    public Text textoPontos;

    public int totalPontos;

    public static Controlador acesso; // acessar essa clase por outro script

    //Atualizar Falhas

    public Text textoFalhas;

    public int totalFalhas;

    //Painel perder

    public GameObject painelPerder;

    // Texto Pontuação final e moedas finais

    public Text pontosFinais;

    public Text moedasFinais;

    //Botão pause

    public GameObject botaoPause;

    //Salvar o jogo

    public bool save;

    //Variaveis para a loja

    public Text moedaLoja;

    private int moedinhas;

    public GameObject semDinheiro;



     
    // Start is called before the first frame update
    void Start()
    {

        acesso = this; // criar uma variavel estatica e atribuir o valor dela ao proprio script
                       // assim, quando eu chamar essa variavel de outro script consigo acessar tudo dele que não seja private

        Moedas = 1000;

        save = false; //save recebe falso, pois no inicio do jogo não queremos que salve.

        moedinhas = PlayerPrefs.GetInt("totalScore"); //relacionar variavel da loja com o save das moedas
      
    }

    private void Update()
    {
        moedaLoja.text = PlayerPrefs.GetInt("totalScore").ToString();
    }


    public void AtualizarMoedas()
    {
        textoMoedas.text = Moedas.ToString();
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
        save = true; //ao acabar o jogo, ele salvará as informações

        Time.timeScale = 0f;

        painelPerder.SetActive(true);

        //mostrar pontuação na tela de perde
        pontosFinais.text = "Pontuação  " + totalPontos.ToString();

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
            //no PlayerPref, usa-se Setin para salvar informaçoes
            PlayerPrefs.Save();
        }
    }

    public void DeleteAll()
    {
        PlayerPrefs.DeleteAll();

    }

    public void Comprar()
    {
        if(moedinhas >= ItemLoja.acesso.preço)
        {
            moedinhas = moedinhas - ItemLoja.acesso.preço;
            PlayerPrefs.SetInt("totalScore", moedinhas);
            PlayerPrefs.Save();

            ItemLoja.acesso.item.SetActive(true);

        }
        else
        {
            semDinheiro.SetActive(true);
        }

    }
}
