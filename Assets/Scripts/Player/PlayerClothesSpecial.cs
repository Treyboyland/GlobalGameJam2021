using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerClothesSpecial : MonoBehaviour
{
    [Serializable]
    public struct SpriteWithAppropriateColor
    {
        public SpriteRenderer SpriteRenderer;
        public Color NormalColor;
        public Color WetColor;
    }


    [SerializeField]
    List<SpriteWithAppropriateColor> sprites = null;

    void SetColor(bool isWet)
    {
        foreach (var sprite in sprites)
        {
            sprite.SpriteRenderer.color = isWet ? sprite.WetColor : sprite.NormalColor;
        }
    }

    public void SetWetColor()
    {
        SetColor(true);
    }

    public void SetDryColor()
    {
        SetColor(false);
    }
}
