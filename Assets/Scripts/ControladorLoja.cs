using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorLoja : MonoBehaviour
{
    public Text textoMoeda;
    public Text[] textobotao;
    public int[] pre�o;
    private int moedinhas;

    void Start()
    {
        //if(PlayerPrefs.GetInt("0") == 0)
        {
            //PlayerPrefs.SetInt("0", 1);
        }
        moedinhas = PlayerPrefs.GetInt("totalScore");
    }
    void Update()
    {
        for(int i = 0; i < textobotao.Length; i++)
        {
            if(PlayerPrefs.GetInt(i.ToString()) == 0)
            {
                textobotao[i].text = pre�o[i].ToString();
            }
            else
            {
                textobotao[i].text = "Selecionar";
            }
        }

        textoMoeda.text = PlayerPrefs.GetInt("totalScore").ToString();
        
    }

    public void ComprarItem(int numeroBotao)
    {
        //caso PlayerPref = 0 ent�o item esta bloqueado
        if (PlayerPrefs.GetInt(numeroBotao.ToString()) == 0)
        {
            //codigo para comprar item e desbloquear
            if(moedinhas >= pre�o[numeroBotao])
            {
                PlayerPrefs.SetInt(numeroBotao.ToString(), 1);
                PlayerPrefs.Save();

                moedinhas = moedinhas - pre�o[numeroBotao];
                PlayerPrefs.SetInt("totalScore", moedinhas);
                PlayerPrefs.Save();
            }
        }
        else
        {
            print("desbloqueado");
            //"seleciona o personagem"
        }
    }
}
