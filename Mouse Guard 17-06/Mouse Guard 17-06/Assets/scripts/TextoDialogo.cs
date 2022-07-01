using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Serializable;
using UnityEngine.UI;
using System;

[System.Serializable]
public class TextoDialogo
{
    [SerializableField]
    [textArea(1,4)]
    private string _frase;

    public string GetFrase()
    {
        return _frase;
    }
}







































































































































