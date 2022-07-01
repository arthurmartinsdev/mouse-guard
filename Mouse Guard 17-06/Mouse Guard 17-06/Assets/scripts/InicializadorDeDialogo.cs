using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Serializable;
using UnityEngine.UI;
using System;

public class InicializadorDeDialogo : MonoBehaviour
{
    [SerializableField]
    private GerenciadorDeDialogo _gerenciador;
    [SerializableField]
    private Dialogo _dialogo;

    public void Inicializa()
    {
        if (_gerenciador == null)
            return;
        _gerenciador.Inicializa(_dialogo);
    }
}
