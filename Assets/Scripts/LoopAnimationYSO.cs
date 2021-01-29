using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Animation Y", menuName = "Custom Animation/Loop Y")]
public class LoopAnimationYSO : ScriptableObject
{
    [Tooltip("Y offset for the item")]
    [SerializeField]
    AnimationCurve curve = null;

    /// <summary>
    /// Y offset for the item
    /// </summary>
    /// <value></value>
    public AnimationCurve Curve { get { return curve; } }


    [Tooltip("Amount of time that this animation should take")]
    [SerializeField]
    float secondsToLoop = 0;

    /// <summary>
    /// Amount of time that this animation should take
    /// </summary>
    /// <value></value>
    public float SecondsToLoop { get { return secondsToLoop; } }

}
