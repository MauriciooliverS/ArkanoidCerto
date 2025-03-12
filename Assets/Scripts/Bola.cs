using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public bool estaVivo = true;
    public int pontos;
    public GAmever gameOver;
    // Start is called before the first frame update
    void Start()
    {
        estaVivo = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.CompareTag("Morte"))
        {
            gameOver.MorrePlayer();
            estaVivo = false;
        }
        if(collision.gameObject.CompareTag("Bases"))
        {
             Destroy(collision.gameObject);
            pontos ++;
        }
        
    }
    
}

    