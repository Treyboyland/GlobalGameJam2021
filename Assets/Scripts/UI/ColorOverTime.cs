using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorOverTime : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textBox = null;

    [SerializeField]
    List<Color> colors = new List<Color>();

    [SerializeField]
    float secondsToChange = 0;

    private void OnEnable()
    {
        StartCoroutine(ColorSwap());
    }


    IEnumerator ColorSwap()
    {
        int chosenIndex = 0;
        float elapsed = 0;
        while (true)
        {
            Color start = textBox.color;
            int newIndex = Random.Range(0, colors.Count);
            if (newIndex == chosenIndex)
            {
                newIndex = (newIndex + 1) % colors.Count;
            }
            chosenIndex = newIndex;
            Color end = colors[chosenIndex];

            while (elapsed < secondsToChange)
            {
                elapsed += Time.deltaTime;
                textBox.color = Color.Lerp(start, end, elapsed / secondsToChange);
                yield return null;
            }
            elapsed = 0;

            textBox.color = end;
            yield return null;
        }
    }
}


