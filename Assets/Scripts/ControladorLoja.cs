using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorLoja : MonoBehaviour
{
    public Text moedaLoja;

    private int moedinhas;

    public GameObject semDinheiro;


    void Start()
    {
        moedinhas = PlayerPrefs.GetInt("totalScore"); //relacionar variavel da loja com o save das moedas
        
        
    }
    void Update()
    {
        moedaLoja.text = PlayerPrefs.GetInt("totalScore").ToString();
    }
    public void Comprar()
    {
        if (moedinhas >= ItemLoja.acesso.preço)
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
