using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartScript : MonoBehaviour
{
    [SerializeField]
    GameEvent startEvent = null;

    bool eventFired = false;

    // Update is called once per frame
    void Update()
    {
        if (!eventFired && Input.anyKeyDown)
        {
            eventFired = true;
            startEvent.Invoke();
        }
    }
}
