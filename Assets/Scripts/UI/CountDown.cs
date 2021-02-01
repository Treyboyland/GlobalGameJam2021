using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    float countDownTime = 0;

    [SerializeField]
    bool isCounting = false;

    [SerializeField]
    GameEvent gameOverEvent = null;

    [SerializeField]
    TextMeshProUGUI textBox = null;

    public bool IsCounting { get { return isCounting; } set { isCounting = value; } }

    float currentTime = 0;

    public float CurrentTime { get { return currentTime; } }

    bool eventFired = false;

    // Start is called before the first frame update
    void Start()
    {
        SetTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            currentTime += Time.deltaTime;
            SetTime();
        }
    }


    void SetTime()
    {
        float timeRemaining = Mathf.Max(0, countDownTime - currentTime);
        if (!eventFired && timeRemaining == 0)
        {
            eventFired = true;
            gameOverEvent.Invoke();
        }
        // Debug.LogWarning("Milliseconds: " + ((timeRemaining % 1) * 1000));
        // Debug.LogWarning("Milliseconds Int: " + (int)((timeRemaining % 1) * 1000));
        TimeSpan span = new TimeSpan(0, 0, 0, (int)timeRemaining, (int)((timeRemaining % 1) * 1000));
        textBox.text = span.ToString("mm\\:ss\\.f");
    }
}
