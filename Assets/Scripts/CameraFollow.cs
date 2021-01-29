using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Vector3 offset = new Vector3();

    [SerializeField]
    GameObject toFollow = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = toFollow.transform.position + offset;
    }
}
