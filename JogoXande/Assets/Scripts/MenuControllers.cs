using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllers : MonoBehaviour
{
    public GameObject creditsPainel;

    public void PlayBTN()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void OpenCreditosPainel()
    {
        creditsPainel.SetActive(true);
    }

    public void CloseCreditosPainel()
    {
        creditsPainel?.SetActive(false);
    }

    public void QuitBTN()
    {
        Application.Quit();
    }
}
