using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorLoja : MonoBehaviour
{
    public Text[] botao_txt;
    public Image[] itens_image;
    public int[] valor;
    private int moedinhas;
    void Start()
    {
        if(PlayerPrefs.GetInt("3") == 0)
        {
            PlayerPrefs.SetInt("0", 1);
        }
        moedinhas = PlayerPrefs.GetInt("moedasTotal");
        
    }

    void Update()
    {
        for(int i=0;i<itens_image.Length;i++)
        {
            if(PlayerPrefs.GetInt(i.ToString()) == 0)
            {
                botao_txt[i].text = valor[i].ToString();
            }
            else
            {
                botao_txt[i].text = "selecionar";
                itens_image[i].gameObject.SetActive(true);
            }
        }
    }

    public void Compraritem(int numeroBotao)
    {
        //playerprefs = 0 significa que o item esta bloqueado
        if(PlayerPrefs.GetInt(numeroBotao.ToString()) == 0)
        {
            //comprar item e desbloquear
            if(moedinhas >= valor[numeroBotao])
            {
                PlayerPrefs.SetInt(numeroBotao.ToString(), 1);
                PlayerPrefs.Save();
                moedinhas = moedinhas - valor[numeroBotao];

                //salvar a nova quantidade de moedas no Total
                PlayerPrefs.SetInt("moedasTotal", moedinhas);
                PlayerPrefs.Save();
            }
        }
        else
        {
            //adicionar ingredientes no jogo
           
        }
    }
}
