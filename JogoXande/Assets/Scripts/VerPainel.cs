using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerPainel : MonoBehaviour
{
    public GameObject painel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        painel.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        painel.SetActive(false);
    }
}
