using System;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TMP_Text _timerText;
    enum TimerType { Countdown, Stopwatch}
    [SerializeField] private TimerType timerType;

    [SerializeField] private float timeToDisplay = 60.0f;

    private bool _isRunning;

    private void Awake()
    {
        _timerText = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
