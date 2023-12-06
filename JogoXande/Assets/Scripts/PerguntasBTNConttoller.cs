using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerguntasBTNConttoller : MonoBehaviour
{
    public GameObject proximaPergunta; // The name of the scene you want to load
    public GameObject pergunta1; // The name of the scene you want to load
    public GameObject perguntaAtual;
    public GameObject painelDasPerguntas;

    public void BTNCerto()
    {
        proximaPergunta.SetActive(true);
        perguntaAtual.SetActive(false);
    }

    public void BTNErrado()
    {
        perguntaAtual.SetActive(false);
        pergunta1.SetActive(true);
    }
    public void BTNLastQuestionCorect()
    {
        perguntaAtual.SetActive(false);
        proximaPergunta.SetActive(true);
        painelDasPerguntas.SetActive(false);
    }
}
