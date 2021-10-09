using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDeObjetos : MonoBehaviour
{
    [SerializeField]
    private GameObject Objeto;

    [SerializeField]
    private bool pararSpawn = false;

    [SerializeField]
    private float tempoDeSpawn;

    [SerializeField]
    private float esperaEntreSpawns;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CriarObjetos",tempoDeSpawn,esperaEntreSpawns); //serve para chamar um metodo "" varias vezes, tempo tempo inicial e tempo de espera 
    }

    public void CriarObjetos()
    {
        Instantiate(Objeto, transform.position, transform.rotation); //clona objetos e retorna o clone dele 
                                                                     //objeto que será criado, posição e rotação 
        if(pararSpawn)
        {
            CancelInvoke("CriarObjetos"); //Para para de spawnar, cancelamos o InvokeRepeating
        }
    }

}
