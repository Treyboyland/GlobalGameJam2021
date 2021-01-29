using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item
{
    /// <summary>
    /// Item data
    /// </summary>
    [SerializeField]
    ItemSO item = null;

    public ItemSO ItemData { get { return item; } }

    /// <summary>
    /// Current state of the item
    /// </summary>
    [SerializeField]
    ItemStateSO currentState = null;

    /// <summary>
    /// Current state of the item
    /// </summary>
    /// <value></value>
    public ItemStateSO CurrentState
    {
        get
        {
            return currentState;
        }
        set
        {
            currentState = value;
        }
    }

    public Item(ItemSO itemData, ItemStateSO stateData)
    {
        item = itemData;
        currentState = stateData;
    }

    public Item(ItemAndState data)
    {
        item = data.Item;
        currentState = data.NewState;
    }
}
