using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool paused;
    private float zoomSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ChangePaused();
        }
    }

    void ChangePaused()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }

}
