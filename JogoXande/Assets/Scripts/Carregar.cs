using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Carregar : MonoBehaviour
{

    bool podeInteragir = false;
    public GameObject Jogador;
    public string CenaACarregar;
    public GameObject text;

    void Update()
    {
        if (podeInteragir == true && Input.GetKeyDown(KeyCode.E))
        {
            Jogador.GetComponent<SalvarPosic>().SalvarLocalizacao();
            SceneManager.LoadScene(CenaACarregar);
        }
    }
    void OnTriggerEnter2D()
    {
        podeInteragir = true;
    }
    void OnTriggerExit2D()
    {
        podeInteragir = false;
    }
    void OnGUI()
    {
        if (podeInteragir == true)
        {
            text.SetActive(true);
        }
        if (podeInteragir == false)
        {
            text.SetActive(false);
        }
    }
}