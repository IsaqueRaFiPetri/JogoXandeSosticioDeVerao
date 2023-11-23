using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuzzlePerguntasRespostas : MonoBehaviour
{
    public GameObject proximaPergunta; // The name of the panel you want to load
    public GameObject pergunta1; // The name of the panel you want to load
    public GameObject perguntaAtual; // The name of the panel you want to load
    [SerializeField] private Button CorrectButton;

    void Awake()
    {
        CorrectButton.onClick.AddListener(OnCorrectButtonClick);
    }

    void OnCorrectButtonClick()
    {
        Debug.Log("Acertou");
    }
    public void PassarParaProximaPergunta()
    {
        proximaPergunta.SetActive(true);
        perguntaAtual.SetActive(false);
    }

    public void Btnerrado()
    {
        perguntaAtual.SetActive(false);
        pergunta1.SetActive(true);
    }
}
