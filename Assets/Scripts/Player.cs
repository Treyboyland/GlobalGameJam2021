using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer playerBody = null;

    [SerializeField]
    List<Item> items = null;

    [SerializeField]
    Color wetColor = Color.blue;

    [SerializeField]
    Color normalColor = Color.white;

    [SerializeField]
    GameEvent hitEvent = null;

    /// <summary>
    /// Adds item to list of items
    /// </summary>
    /// <param name="newItem"></param>
    public void AddItem(Item newItem)
    {
        //Only allowing one of each item
        if (HasItem(newItem.ItemData))
        {
            return;
        }

        items.Add(newItem);
    }

    public void AddItem(ItemAndState data)
    {
        if (HasItem(data.Item))
        {
            return;
        }
        items.Add(new Item(data));
    }

    /// <summary>
    /// Removes items from list of items
    /// </summary>
    /// <param name="newItem"></param>
    public void RemoveItem(Item newItem)
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            var item = items[i];
            if (item.ItemData == newItem.ItemData)
            {
                items.RemoveAt(i);
            }
        }
    }

    public void RemoveItem(ItemSO toRemove)
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            var item = items[i];
            if (item.ItemData == toRemove)
            {
                items.RemoveAt(i);
            }
        }
    }

    /// <summary>
    /// If player has item, changes item to given state
    /// </summary>
    /// <param name="toChange"></param>
    /// <param name="newState"></param>
    public void ChangeItemState(ItemSO toChange, ItemStateSO newState)
    {
        foreach (var item in items)
        {
            if (item.ItemData == toChange)
            {
                item.CurrentState = newState;
            }
        }
    }

    /// <summary>
    /// True if player has item
    /// </summary>
    /// <param name="toCheck"></param>
    /// <returns></returns>
    public bool HasItem(ItemSO toCheck)
    {
        foreach (var item in items)
        {
            if (item.ItemData == toCheck)
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// True if player has item, and item is currently in the given state
    /// </summary>
    /// <param name="itemToCheck"></param>
    /// <param name="stateToCheck"></param>
    /// <returns></returns>
    public bool IsItemInState(ItemSO itemToCheck, ItemStateSO stateToCheck)
    {
        foreach (var item in items)
        {
            if (item.ItemData == itemToCheck && item.CurrentState == stateToCheck)
            {
                return true;
            }
        }

        return false;
    }


    public void MakeWet()
    {
        playerBody.color = wetColor;
    }

    public void MakeDry()
    {
        playerBody.color = normalColor;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        hitEvent.Invoke();
    }
}
