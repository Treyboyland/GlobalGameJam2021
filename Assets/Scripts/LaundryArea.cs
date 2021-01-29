using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaundryArea : MonoBehaviour
{
    [SerializeField]
    ItemSO clothesItem = null;

    [SerializeField]
    ItemSO maskItem = null;

    [SerializeField]
    ItemStateSO wetState = null;

    [SerializeField]
    GameEvent startDryer = null;

    [SerializeField]
    GameEvent clothesRemoved = null;

    [SerializeField]
    GameEvent maskRemoved = null;

    private void OnTriggerEnter2D(Collider2D other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        {
            bool maskNeeded = false, clothesNeeded = false;
            if (player.IsItemInState(clothesItem, wetState))
            {
                player.RemoveItem(clothesItem);
                clothesRemoved.Invoke();
                clothesNeeded = true;
            }
            if (player.IsItemInState(maskItem, wetState))
            {
                player.RemoveItem(maskItem);
                maskRemoved.Invoke();
                maskNeeded = true;
            }
            if (maskNeeded || clothesNeeded)
            {
                startDryer.Invoke();
            }

        }
    }
}
