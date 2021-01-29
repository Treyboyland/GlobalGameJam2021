using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName = "Items/Item", order = -1)]
public class ItemSO : ScriptableObject
{
    /// <summary>
    /// Name of the item
    /// </summary>
    [Tooltip("Name of the item")]
    [SerializeField]
    string itemName = null;

    /// <summary>
    /// Name of the item
    /// </summary>
    /// <value></value>
    public string ItemName
    {
        get
        {
            return itemName;
        }
    }
}
