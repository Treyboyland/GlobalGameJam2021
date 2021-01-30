using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{

    public bool CanQuit { get; set; } = true;


    // Update is called once per frame
    void Update()
    {
#if UNITY_WEBGL
        //Do nothing
#else
        if (CanQuit && Input.GetButtonDown("Reload"))
        {
            Application.Quit();
        }
#endif
    }
}
