using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class FinalTimeUi : MonoBehaviour
{
    [SerializeField]
    CountDown countDown = null;

    [SerializeField]
    TextMeshProUGUI textBox = null;

    public void SetFinalTime()
    {
        float timeRemaining = countDown.CurrentTime;

        TimeSpan span = new TimeSpan(0, 0, 0, (int)timeRemaining, (int)((timeRemaining % 1) * 1000));

        textBox.text = "Time: " + span.ToString("mm\\:ss\\.fff");
    }
}
