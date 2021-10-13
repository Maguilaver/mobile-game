using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemLoja : MonoBehaviour
{

    //dar acesso para o controlador
    public static ItemLoja acesso;

    //Preço Item
    // cama 50
    // quadro 250
    //planta 85
    // sofa 100
    //prate 150

    //salvar itens
    public static int cama;
    public static int quadro;
    public static int planta;
    public static int sofa;
    public static int prate;

    //itens
    public GameObject Cama;
    public GameObject Quadro;
    public GameObject Planta;
    public GameObject Prate;
    public GameObject Sofa;

    //botões
    public GameObject botCama;
    public GameObject botQuadro;
    public GameObject botPlanta;
    public GameObject botPrate;
    public GameObject botSofa;

    //salvar 
    // public int Comprado;




    void Start()

    {
        acesso = this;

        cama = PlayerPrefs.GetInt("cama", 1);
        quadro = PlayerPrefs.GetInt("quadro", 1);
        planta = PlayerPrefs.GetInt("planta", 1);
        sofa = PlayerPrefs.GetInt("sofa", 1);
        prate = PlayerPrefs.GetInt("prate", 1);

    }

    private void Update()
    {
        //checagem do save
        if (cama == 1)
        {
            Cama.SetActive(false);
        }

        if (cama == 2)
        {
            Cama.SetActive(true);
            botCama.SetActive(false);
        }

        if (quadro == 1)
        {
            Quadro.SetActive(false);
        }

        if (quadro == 2)
        {
            Quadro.SetActive(true);
            botQuadro.SetActive(false);

        }
    

        if (planta == 1)
        {
            Planta.SetActive(false);
            
        }

        if (planta == 2)
        {
            Planta.SetActive(true);
            botPlanta.SetActive(false);

        }

        if (prate == 1)
        {
            Prate.SetActive(false);

        }

        if (prate == 2)
        {
            Prate.SetActive(true);
            botPrate.SetActive(false);

        }

        if (sofa == 1)
        {
            Sofa.SetActive(false);

        }

        if (sofa == 2)
        {
            Sofa.SetActive(true);
            botSofa.SetActive(false);

        }
    }
}

