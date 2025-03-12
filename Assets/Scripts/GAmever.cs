using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;


public class GAmever : MonoBehaviour
{
   public GameObject GameOver;
   public GameObject Ganhou;
   public GameObject Pontos;
   public Bola bolinha;
    public TextMeshProUGUI textoPontos;
    public TextMeshProUGUI textoPontos2;
    public TextMeshProUGUI textoPontos3;
    public TextMeshProUGUI textoPontos4;
    public TextMeshProUGUI textoPontos5;
    public TextMeshProUGUI textoPontos6;
    public TextMeshProUGUI textoPontos7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        GameOver.SetActive(false); 
        Ganhou.SetActive(false); 
        Pontos.SetActive(true); 
         AtualizarTexto();  
        Time.timeScale = 1;      
    }
    void Update()
    {
        AtualizarTexto(); 
        
    }
    public void VivePlayer()
    {
        GameOver.SetActive(false); 
        SceneManager.LoadScene("Fase1");
          
    }

    // Update is called once per frame
    public void MorrePlayer()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }
    public void VoltaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    void AtualizarTexto()
    {
         textoPontos.text =  bolinha.pontos.ToString() + " Pontos" ;
         textoPontos2.text = bolinha.pontos.ToString() + " Pontos" ;
         textoPontos3.text = bolinha.pontos.ToString() + " Pontos" ;
         textoPontos4.text = bolinha.pontos.ToString() + " Pontos" ;
         if ( bolinha.pontos == 81 )
         {
            GanhaPlayer();
         }
    }
    
    void GanhaPlayer()
    {
        Time.timeScale = 0;
        Ganhou.SetActive(true); 
        textoPontos5.text = bolinha.pontos.ToString() + " Pontos!!!" ;
        textoPontos6.text = bolinha.pontos.ToString() + " Pontos!!!" ;
        textoPontos7.text = bolinha.pontos.ToString() + " Pontos!!!" ;
        Pontos.SetActive(false);
    }
    
        
    
}
