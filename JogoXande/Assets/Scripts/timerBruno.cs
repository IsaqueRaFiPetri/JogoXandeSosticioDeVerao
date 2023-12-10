using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class timerBruno : MonoBehaviour
{
    static float timer =300;
    TimeSpan timerSpan = TimeSpan.FromSeconds(timer);
    public TextMeshProUGUI textMeshProUGUI;
    public GameObject derrotaPainel;

    
    void Update()
    {
        timer -= Time.deltaTime;
        timerSpan = TimeSpan.FromSeconds(timer);
        if (timer < 0) {
            derrotaPainel.SetActive(true);
            Time.timeScale = 0;

        }
        textMeshProUGUI.text = timerSpan.ToString(@"mm\:ss");
    }
    public void RestartBTN()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
        derrotaPainel.SetActive(false);
        timer = 300;
    }
    public void MenuBTN()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1;
        derrotaPainel.SetActive(false);
        timer = 300;
    }
    public void QuitBTN()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }
}
// https://stackoverflow.com/questions/463642/how-can-i-convert-seconds-into-hourminutessecondsmilliseconds-time
// https://stackoverflow.com/questions/6356351/formatting-a-float-to-2-decimal-places
//textMeshProUGUI.text = timerSpan.ToString(@"mm\:ss\:ff");
