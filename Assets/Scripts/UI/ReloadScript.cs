using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScript : MonoBehaviour
{
    [SerializeField]
    bool canReload = false;

    public bool CanReload
    {
        get
        {
            return canReload;
        }
        set
        {
            canReload = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canReload && Input.GetButtonDown("Reload"))
        {
            SceneManager.LoadScene("_Scenes/Game", LoadSceneMode.Single);
        }
    }
}
