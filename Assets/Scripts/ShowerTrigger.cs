using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerTrigger : MonoBehaviour
{
    [SerializeField]
    GameEvent showerEntered = null;

    [SerializeField]
    GameEvent showerExited = null;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        {
            showerEntered.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        {
            showerExited.Invoke();
        }
    }
}
