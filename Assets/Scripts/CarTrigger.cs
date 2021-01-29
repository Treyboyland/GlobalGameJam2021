using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    [SerializeField]
    GameEvent gameWinEvent;

    [SerializeField]
    GameEvent notDoneEvent;

    public bool CanWinGame { get; set; } = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<Player>();

        if (player == null)
        {
            return;
        }

        if (CanWinGame)
        {
            gameWinEvent.Invoke();
        }
        else
        {
            notDoneEvent.Invoke();
        }
    }
}
