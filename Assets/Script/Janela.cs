using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janela : MonoBehaviour
{
    public Texture[] Texturas;
    private int Indice = 1;

    private Ponto ponto;

    void Start()
    {
        ponto = FindObjectOfType(typeof(Ponto)) as Ponto;
    }

    void OnTouchDown()
    {
        GetComponent<MeshRenderer>().material.mainTexture = Texturas[Indice];
        Indice = 1;
        ponto.addPonto();
    }
}
