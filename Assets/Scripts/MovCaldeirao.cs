using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCaldeirao : MonoBehaviour
{
    //Movimentação
    private Rigidbody2D rbCaldeirao;
    private float dirX;

    [SerializeField]
    private float velocidade;



    // Start is called before the first frame update
    void Start()
    {
        rbCaldeirao = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() // chamado  a cada frame do jogo, pode variar
    {
        dirX = Input.acceleration.x * velocidade;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -1.5f, 1.5f), transform.position.y); //criar limites para a bola
        
    }

    private void FixedUpdate()  //FixedUpdate é chamado em um intervalo fixo de jogo,tempo que a unity faz os calculos de fisica 
    {
        rbCaldeirao.velocity = new Vector2(dirX, 0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Animais")
        {
            Controlador.acesso.Perder();
        }

        if (collision.CompareTag("Moedas") == true)
        {
            Controlador.acesso.totalMoedas = Controlador.acesso.totalMoedas + 1;
            Controlador.acesso.AtualizarMoedas();

            Destroy(collision.gameObject);
        }
    }


}
