using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MutarJogo : MonoBehaviour
{
    private bool estaMutado;

    [SerializeField]
    GameObject efeitosSonoros;
    // Start is called before the first frame update
    void Start()
    {
        estaMutado = PlayerPrefs.GetInt("Mutado") == 1;
        AudioListener.pause = estaMutado;

        //PlayerPrefs não trabalha com bool, logo teremos que definir valores de 0 e 1 para verdadeiro e falso
    }

  

    public void Mutar()
    {
        estaMutado = !estaMutado;
        AudioListener.pause = estaMutado;
       /* if (estaMutado)
            efeitosSonoros.SetActive(false);
        else
            efeitosSonoros.SetActive(true);
       */

        PlayerPrefs.SetInt("Mutado", estaMutado ? 1 : 0);
        
        PlayerPrefs.Save();
    }
}
