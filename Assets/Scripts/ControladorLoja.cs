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
    public void ComprarCama()
    {
        if (moedinhas >= 15)
        {
            ItemLoja.cama = 2;
            PlayerPrefs.SetInt("cama", ItemLoja.cama);
            PlayerPrefs.Save();
            moedinhas = moedinhas - 15;
            PlayerPrefs.SetInt("totalScore", moedinhas);
            PlayerPrefs.Save();

        }
        else
        {
            semDinheiro.SetActive(true);
        }

    }

    public void ComprarQuadro()
    {
        if (moedinhas >= 100)
        {
            ItemLoja.quadro = 2;
            PlayerPrefs.SetInt("quadro", ItemLoja.quadro);
            PlayerPrefs.Save();
            moedinhas = moedinhas - 100;
            PlayerPrefs.SetInt("totalScore", moedinhas);
            PlayerPrefs.Save();

        }
        else
        {
            semDinheiro.SetActive(true);
        }

    }


    public void ComprarPlanta()
    {
        if (moedinhas >= 20)
        {
            ItemLoja.planta = 2;
            PlayerPrefs.SetInt("planta", ItemLoja.planta);
            PlayerPrefs.Save();
            moedinhas = moedinhas - 20;
            PlayerPrefs.SetInt("totalScore", moedinhas);
            PlayerPrefs.Save();

        }
        else
        {
            semDinheiro.SetActive(true);
        }

    }

    public void ComprarSofa()
    {
        if (moedinhas >= 50)
        {
            ItemLoja.sofa = 2;
            PlayerPrefs.SetInt("sofa", ItemLoja.sofa);
            PlayerPrefs.Save();
            moedinhas = moedinhas - 50;
            PlayerPrefs.SetInt("totalScore", moedinhas);
            PlayerPrefs.Save();

        }
        else
        {
            semDinheiro.SetActive(true);
        }

    }

    public void ComprarPrate()
    {
        if (moedinhas >= 75)
        {
            ItemLoja.prate = 2;
            PlayerPrefs.SetInt("prate", ItemLoja.prate);
            PlayerPrefs.Save();
            moedinhas = moedinhas - 75;
            PlayerPrefs.SetInt("totalScore", moedinhas);
            PlayerPrefs.Save();

        }
        else
        {
            semDinheiro.SetActive(true);
        }

    }

}
