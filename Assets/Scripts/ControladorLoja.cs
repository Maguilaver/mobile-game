using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorLoja : MonoBehaviour
{
    //dinheiro
    public Text moedaLoja;

    private int moedinhas;

    //painel
    public GameObject semDinheiro;

    


    void Start()
    {
        moedinhas = PlayerPrefs.GetInt("totalScore"); //relacionar variavel da loja com o save das moedas

       //ItemLoja.acesso.Comprado = PlayerPrefs.GetInt("Comprado", 1);
    }
    void Update()
    {
        moedaLoja.text = PlayerPrefs.GetInt("totalScore").ToString();

      /*  if(ItemLoja.acesso.Comprado == 1)
        {
            ItemLoja.acesso.item.SetActive(false);
        }

        if(ItemLoja.acesso.Comprado == 2)
        {
            ItemLoja.acesso.item.SetActive(true);
        }
      */
    }
    public void Comprar()
    {
        if (moedinhas >= ItemLoja.acesso.preço)
        {
            //salvar
          //ItemLoja.acesso.Comprado = 2;
          //PlayerPrefs.SetInt("Comprado", ItemLoja.acesso.Comprado);
           //PlayerPrefs.Save();
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
