using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternateObjectsOverTime : MonoBehaviour
{
    [SerializeField]
    List<GameObject> objects = null;

    [SerializeField]
    float secondsToWait = 0;



    private void OnEnable()
    {
        DisableAll();
        StartCoroutine(Cycle());
    }

    void DisableAll()
    {
        foreach (var obj in objects)
        {
            obj.SetActive(false);
        }
    }

    IEnumerator Cycle()
    {
        int index = 0;
        while (true)
        {
            var obj = objects[index];
            obj.SetActive(true);
            yield return new WaitForSeconds(secondsToWait);
            obj.SetActive(false);
            index = (index + 1) % objects.Count;
        }
    }
}
