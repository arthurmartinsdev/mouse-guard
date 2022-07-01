using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Serializable;
using UnityEngine.UI;   
using System;

[System.Serializable]
public class Dialogo
{
    [SerializableField]
    private string _frase;

    [SerializableField]
    private string _NomePers;

    public string GetFrase()
    {
        return frase;
    }

    public string GetNomePers() 
    {
        return _NomePers;
    }
}
