using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemState", menuName = "Items/Item State")]
public class ItemStateSO : ScriptableObject
{
    /// <summary>
    /// Name of this state (if needed)
    /// </summary>
    [Tooltip("Name of this state (if needed)")]
    [SerializeField]
    string stateName = null;

    /// <summary>
    /// Name of this state (if needed)
    /// </summary>
    /// <value></value>
    public string StateName { get { return stateName; } }
}
