using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool paused;
    private bool diff;

    void Start()
    {
        foreach (GameObject spawner in GameObject.FindGameObjectsWithTag("Spawner"))
        {
            if (spawner.name == "Director")
            {
                /*if(diff = 1)
                {
                    WaveSpawnerEasy();
                }
                else if (diff = 2)
                {
                    WaveSpawenerMed();
                }
                else if (diff = 3)
                {
                    WaveSpawnerHard();
                }*/
            }
        } 
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

    void WaveSpawnerEasy()
    {

    }
    void WaveSpawenerMed()
    {

    }
    void WaveSpawnerHard()
    {

    }
}
