using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaundryTime : MonoBehaviour
{
    //TODO: Timer class...

    [SerializeField]
    float secondsToWait = 0;

    [SerializeField]
    GameEvent laundryDone = null;

    [SerializeField]
    bool canCount = false;

    public bool CanCount { get { return canCount; } set { canCount = value; } }

    public bool ShouldSpawnMask { get; set; } = false;

    public bool ShouldSpawnClothes { get; set; } = false;

    bool eventFired = false;

    float currentTime = 0;

    // Update is called once per frame
    void Update()
    {
        if (canCount)
        {
            currentTime += Time.deltaTime;
            if (!eventFired && currentTime >= secondsToWait)
            {
                eventFired = true;
                laundryDone.Invoke();
            }
        }
    }
}
