using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorDeFalhas : MonoBehaviour
{
    [SerializeField]
    private int falhas = 0; 

    //Pensar no slow update

    private void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ingredientes")
        {
            falhas++;

            Destroy(GameObject.FindWithTag("ingredientes"));
        }
    }
}
