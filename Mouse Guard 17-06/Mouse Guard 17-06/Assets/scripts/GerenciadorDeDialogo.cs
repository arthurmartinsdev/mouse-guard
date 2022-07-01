using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Serializable;
using System;

public class GerenciadorDeDialogo : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _NomePers;
    [SerializeField]
    private Image _CaixaDeDialogo;
    [SerializeField]
    private TMP_Text _texto;
    [SerializeField]
    private TMP_Text _prosseguir;

    private int _contador = 0;
    private Dialogo _dialogoAtual;

    public void Inicializa(Dialogo dialogo)
    {
        _contador = 0;
        _dialogoAtual = dialogo;
    }

    public void ProximaFrase()
    {
        if (_dialogoAtual == null)
            return;
        if (_contador == _dialogoAtual.GetFrases().Length)
        {
            _CaixaDeDialogo.gameObject.SetActive(false);
            _dialogoAtual = null;
            _contador = 0;
            return;
        }
        _nomeNpc.text = _dialogoAtual.GetNomePers();
        _texto.text = _dialogoAtual.GetFrases()[_contador].GetFrase();
        _CaixaDeDialogo.gameObject.SetActive(true);
        _contador++;    

    }
}