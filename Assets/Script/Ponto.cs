using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ponto : MonoBehaviour
{
    public GUIText pontuacao;
    private int pontos;

    // Use this for initialization
    void Start ()
    {
        pontos = 0;
    }

    /*void OnMouseDown()
    {
        
        
    }*/

    public void addPonto()
    {
        pontos = pontos + 1;
        pontuacao.text = "Pontos: " + pontos;
    }
}
