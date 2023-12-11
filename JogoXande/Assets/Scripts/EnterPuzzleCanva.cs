using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPuzzleCanva : MonoBehaviour
{
    public GameObject painelDoPuzzle; // The name of the painel you want to load
    public KeyCode keyToPress = KeyCode.E; // Change this to the key you want to use
    
    private void OnTriggerStay2D()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            painelDoPuzzle.SetActive(true);
        }
    }
}
