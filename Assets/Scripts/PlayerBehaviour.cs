using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera camFps;
    public Camera camOverview;
    public KeyCode keyCode;

    void Start()
    {
        camFps.enabled = true;
        camOverview.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            camFps.enabled = !camFps.enabled;
            camOverview.enabled = !camOverview.enabled;
        }
    }
}
