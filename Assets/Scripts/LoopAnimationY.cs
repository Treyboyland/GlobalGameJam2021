using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopAnimationY : MonoBehaviour
{
    [SerializeField]
    LoopAnimationYSO animationData = null;

    float time = 0;

    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
    }


    void UpdatePosition()
    {
        time += Time.deltaTime;
        //Debug.LogWarning(time);
        var newPos = startPos;
        newPos.y += animationData.Curve.Evaluate(Mathf.Lerp(0, 1, (time % animationData.SecondsToLoop) / animationData.SecondsToLoop));
        transform.position = newPos;
    }
}
