using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCheck : MonoBehaviour
{
    [SerializeField]
    GameEvent closeDoor = null;

    [SerializeField]
    GameEvent openDoor = null;

    [SerializeField]
    ItemSO code = null;

    [SerializeField]
    bool runCheck = true;


    public bool RunCheck { get { return runCheck; } set { runCheck = value; } }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!runCheck)
        {
            return;
        }

        var player = other.GetComponent<Player>();
        if (player == null)
        {
            return;
        }

        if (player.HasItem(code))
        {
            openDoor.Invoke();
        }
        else
        {
            closeDoor.Invoke();
        }
    }
}
