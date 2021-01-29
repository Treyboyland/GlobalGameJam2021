using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OversleepController : MonoBehaviour
{
    [SerializeField]
    float secondsBeforeOversleeping = 0;

    [SerializeField]
    GameEvent overSleepEvent = null;

    [SerializeField]
    bool canCount = false;

    public bool CanCount
    {
        get
        {
            return canCount;
        }
        set
        {
            canCount = value;
        }
    }


    float currentTime = 0;

    bool eventFired = false;

    // Update is called once per frame
    void Update()
    {
        if (canCount)
        {
            currentTime += Time.deltaTime;
            if (!eventFired && currentTime >= secondsBeforeOversleeping)
            {
                eventFired = true;
                overSleepEvent.Invoke();
            }
        }
    }
}
