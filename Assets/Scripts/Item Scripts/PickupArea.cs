using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PickupArea : MonoBehaviour
{
    [SerializeField]
    Item item = null;

    [SerializeField]
    List<ItemAndState> stateChanges = null;

    [SerializeField]
    GameEvent pickupEvent = null;

    [SerializeField]
    bool disableAfterPickup = true;

    [SerializeField]
    GameObject objectToDisable = null;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        {
            if (item != null && item.ItemData != null)
            {
                player.AddItem(item);
            }
            foreach (var change in stateChanges)
            {
                player.ChangeItemState(change.Item, change.NewState);
            }

            if (pickupEvent != null)
            {
                pickupEvent.Invoke();
            }
            if (disableAfterPickup)
            {
                objectToDisable.SetActive(false);
            }
        }

    }
}
