using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DoorCode")]
public class DoorCode : ScriptableObject
{
    [SerializeField]
    int codeLength = 0;

    public int CodeLength
    {
        get
        {
            return codeLength;
        }
    }

    int code = 0;

    public int Code { get { return code; } }

    public void RandomizeCode()
    {
        //What might be more interesting is to prevent duplicates...but time
        int max = 1;
        for (int i = 0; i < codeLength; i++)
        {
            max *= 10;
        }
        code = UnityEngine.Random.Range(0, max);
    }
}
