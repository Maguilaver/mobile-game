using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCaldeirao : MonoBehaviour
{
    //Movimenta��o
    private Rigidbody2D rbCaldeirao;
    private float dirX;

    [SerializeField]
    private float velocidade;

   //pontos 


    // Start is called before the first frame update
    void Start()
    {
        rbCaldeirao = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * velocidade;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -1.5f, 1.5f), transform.position.y); //criar limites para a bola
        
    }

    private void FixedUpdate()
    {
        rbCaldeirao.velocity = new Vector2(dirX, 0f);
    }





}