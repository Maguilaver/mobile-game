using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LojaTeste : MonoBehaviour
{
    //pegar dinheiro total
    public Text dinheiroTotal;
    public int MoedasTotais;

    //itens
    public int valorItem;

    public GameObject item;

    //painel pobre 

    public GameObject semDinheiro;
    // Start is called before the first frame update
    void Start()

    {   
        dinheiroTotal.text = MoedasTotais.ToString();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Comprar()
    {
        if (MoedasTotais > valorItem)
        {
            MoedasTotais -= valorItem;

            dinheiroTotal.text = MoedasTotais.ToString();
            item.SetActive(true);
        }
        else
        {
            semDinheiro.SetActive(true);
        }


    }
}
