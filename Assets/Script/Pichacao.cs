using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pichacao : MonoBehaviour
{
    private Ponto ponto;

    void Start()
    {
        gameObject.SetActive(true);
        ponto = FindObjectOfType(typeof(Ponto)) as Ponto;
    }

    void OnMouseDown()
    {
        gameObject.SetActive(false);
        ponto.addPonto();
    }

    void OnTouchDown()
    {
        gameObject.SetActive(false);
        ponto.addPonto();
    }
}