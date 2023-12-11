using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerObjetivo : MonoBehaviour
{
    public GameObject painelObjetivos;

    public void AbrirObjetivo()
    {
        painelObjetivos.SetActive(true);
        Time.timeScale = 0f;
    }

    public void FecharObjetivos()
    {
        painelObjetivos.SetActive(false);
        Time.timeScale = 1f;
    }
}
