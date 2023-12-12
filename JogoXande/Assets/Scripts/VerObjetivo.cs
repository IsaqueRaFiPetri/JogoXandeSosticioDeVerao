using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerObjetivo : MonoBehaviour
{
    public GameObject painelObjetivos;

    public void AbrirObjetivo()
    {
        painelObjetivos.SetActive(true);
    }

    public void FecharObjetivos()
    {
        painelObjetivos.SetActive(false);
    }
}
