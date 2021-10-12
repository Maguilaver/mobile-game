using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TROCAR : MonoBehaviour
{
    //Nome da cena

    [SerializeField]
    string cena;

    //Transição

    public Animator transi; //animação da transição
    public float tempoTransi;

    public void Carregar()
    {
        StartCoroutine(CarregarProxCena());
    }
    IEnumerator CarregarProxCena()
    {
        Time.timeScale = 1f;
        transi.SetTrigger("iniciar"); //tocar a animação
        yield return new WaitForSeconds(tempoTransi);
        SceneManager.LoadScene(cena);
    }

}
