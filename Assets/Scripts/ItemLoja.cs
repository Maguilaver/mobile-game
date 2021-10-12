using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemLoja : MonoBehaviour
{

    //dar acesso para o controlador
    public static ItemLoja acesso;

    //itens
    public int preço;

    public GameObject item;

    //salvar 
   // public int Comprado;




    void Start()

    {
        acesso = this;


    }

}