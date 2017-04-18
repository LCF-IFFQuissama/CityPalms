using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toque : MonoBehaviour
{
    /*public Color defaultColour;
    public Color selectedColour;
    private Material mat;*/

    public bool Dedo = false;
    public GameObject Quadro;

    void Start ()
    {
        gameObject.active = false;
    }

    void OnTouchDown()
    {
        //mat = GetComponent<Renderer>().material;
        Dedo = true;
        if (Dedo == true)
        {
            gameObject.active = true;
        }
        Dedo = false;
    }

    void OnTouchUp()
    {
        //mat.color = defaultColour;
        Dedo = false;
        if (Dedo == false)
        {
            gameObject.active = false;
        }
    }

    void OnTouchStay()
    {
        //mat.color = selectedColour;
        Dedo = true;
        if (Dedo == true)
        {
            gameObject.active = true;
        }
        Dedo = false;
    }

    void OnTouchExit()
    {
        //mat.color = defaultColour;
        Dedo = false;
        if (Dedo == false)
        {
            gameObject.active = false;
        }
    }
}
