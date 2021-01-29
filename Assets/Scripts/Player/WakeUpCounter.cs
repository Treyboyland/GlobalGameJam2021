using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUpCounter : MonoBehaviour
{
    [SerializeField]
    int numTimesToMove = 10;

    [SerializeField]
    GameEvent playerAwoken = null;

    [SerializeField]
    bool shouldCount = false;

    public bool ShouldCount
    {
        get
        {
            return shouldCount;
        }
        set
        {
            shouldCount = value;
        }
    }

    int currentTimesMoved = 0;

    // Update is called once per frame
    void Update()
    {
        if (shouldCount && (Input.GetButtonDown("Left") || Input.GetButtonDown("Right")))
        {
            currentTimesMoved++;
            if (currentTimesMoved >= numTimesToMove)
            {
                playerAwoken.Invoke();
            }
        }
    }
}
