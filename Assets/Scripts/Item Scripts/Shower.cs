using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shower : MonoBehaviour
{
    [SerializeField]
    ParticleSystem water = null;


    // Start is called before the first frame update
    void Start()
    {
        Clear();
    }

    void Clear()
    {
        water.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }

    public void StopShower()
    {
        water.Stop(true, ParticleSystemStopBehavior.StopEmitting);
    }

    public void StartShower()
    {
        water.Play();
    }
}
