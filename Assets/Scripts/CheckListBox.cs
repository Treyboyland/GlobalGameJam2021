using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckListBox : MonoBehaviour
{
    [SerializeField]
    GameObject box = null;

    [SerializeField]
    TextMeshProUGUI textBox = null;

    bool isDone = false;

    public bool IsDone
    {
        get
        {
            return isDone;
        }
        set
        {
            isDone = value;
            box.SetActive(isDone);
        }
    }

    public void SetText(ItemAndState data)
    {
        textBox.text = data.Item.ItemName + (data.NewState != null ? " (" + data.NewState.StateName + ")" : "");
    }
}