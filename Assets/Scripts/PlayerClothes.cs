using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothes : MonoBehaviour
{
    [SerializeField]
    List<SpriteRenderer> sprites = null;

    [SerializeField]
    Color normalColor = Color.white;

    [SerializeField]
    Color wetColor = Color.white;

    void SetColor(Color color)
    {
        foreach (var sprite in sprites)
        {
            sprite.color = color;
        }
    }

    public void SetWetColor()
    {
        SetColor(wetColor);
    }

    public void SetDryColor()
    {
        SetColor(normalColor);
    }
}
