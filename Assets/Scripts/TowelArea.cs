using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TowelArea : MonoBehaviour
{
    [SerializeField]
    ItemSO bodyItem = null;

    [SerializeField]
    ItemStateSO wetState = null;

    [SerializeField]
    ItemStateSO cleanState = null;

    [SerializeField]
    GameEvent playerDry = null;


    [Serializable]
    public struct StateChanges
    {
        public ItemSO Item;
        public ItemStateSO NewState;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<Player>();
        if (player != null && player.IsItemInState(bodyItem, wetState))
        {
            player.ChangeItemState(bodyItem, cleanState);
            playerDry.Invoke();
        }
    }
}
