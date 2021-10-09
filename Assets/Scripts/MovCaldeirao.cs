using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCaldeirao : MonoBehaviour
{
    
    Rigidbody2D rbCaldeirao;
    float dirX;

    [SerializeField]
    public float velocidade;
   


    // Start is called before the first frame update
    void Start()
    {
        rbCaldeirao = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * velocidade;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
        
    }

    private void FixedUpdate()
    {
        rbCaldeirao.velocity = new Vector2(dirX, 0f);
    }
}
