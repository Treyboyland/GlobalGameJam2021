using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAlphaToValueAtStart : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer sr = null;

    [SerializeField]
    float alpha = 0;

    private void OnEnable()
    {
        var color = sr.color;
        color.a = alpha;
        sr.color = color;
    }
}
