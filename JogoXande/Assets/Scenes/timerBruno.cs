using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class timerBruno : MonoBehaviour
{
    static float timer = 180;
    TimeSpan timerSpan = TimeSpan.FromSeconds(timer);
    public TextMeshProUGUI textMeshProUGUI;
    
    void Update()
    {
        timer -= Time.deltaTime;
        timerSpan = TimeSpan.FromSeconds(timer);
        if (timer < 0) {
            print("boom");
            timer = 180;
        }
        textMeshProUGUI.text = timerSpan.ToString(@"mm\:ss\:ff");


    }
}
// https://stackoverflow.com/questions/463642/how-can-i-convert-seconds-into-hourminutessecondsmilliseconds-time
// https://stackoverflow.com/questions/6356351/formatting-a-float-to-2-decimal-places
