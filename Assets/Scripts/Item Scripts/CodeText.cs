using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeText : MonoBehaviour
{
    [SerializeField]
    TextMeshPro textBox = null;

    [SerializeField]
    DoorCode code = null;

    public void SetText()
    {
        textBox.text = code.Code.ToString("D4");
    }
}
