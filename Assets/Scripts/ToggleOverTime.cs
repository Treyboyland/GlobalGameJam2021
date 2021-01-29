using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOverTime : MonoBehaviour
{
    [SerializeField]
    GameObject toToggle = null;

    [SerializeField]
    float secondsToWaitOn = 0;

    [SerializeField]
    float secondsToWaitOff;

    private void Start()
    {
        toToggle.SetActive(false);
        StartCycle();
    }

    public void StartCycle()
    {
        StartCoroutine(Cycle());
    }

    public void StopCycle()
    {
        StopAllCoroutines();
        toToggle.SetActive(false);
    }


    IEnumerator Cycle()
    {
        int index = 0;
        while (true)
        {
            bool isActive = index == 0;
            toToggle.SetActive(isActive);
            yield return new WaitForSeconds(isActive ? secondsToWaitOn : secondsToWaitOff);
            index = (index + 1) % 2;
        }
    }
}
