using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{
    [SerializeField]
    Vector3 minOffset = new Vector3();

    [SerializeField]
    Vector3 maxOffset = new Vector3();

    [SerializeField]
    bool canVibrate = false;


    public bool CanVibrate { get { return canVibrate; } set { canVibrate = value; } }

    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = canVibrate ? Vibrate() : startPos;
    }

    float RandomVal(float a, float b)
    {
        return UnityEngine.Random.Range(a, b);
    }

    Vector3 Vibrate()
    {
        var x = RandomVal(minOffset.x, maxOffset.y) + startPos.x;
        var y = RandomVal(minOffset.y, maxOffset.y) + startPos.y;
        return new Vector3(x, y, transform.position.z);
    }
}
