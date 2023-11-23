using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterPuzzleScene : MonoBehaviour
{
    public string sceneNameToLoad; // The name of the scene you want to load
    public KeyCode keyToPress = KeyCode.Alpha0; // Change this to the key you want to use
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
