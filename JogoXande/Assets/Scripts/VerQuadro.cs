using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerQuadro : MonoBehaviour
{
    public GameObject quadroPainel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        quadroPainel.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        quadroPainel.SetActive(false);
    }
}
