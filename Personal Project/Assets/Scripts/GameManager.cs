using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool paused;
    private int difficuty;

    void Start()
    {
        foreach (GameObject spawner in GameObject.FindGameObjectsWithTag("Spawner"))
        {
            if (spawner.name == "Director")
            {
                if(difficuty = 1)
                {
                    WaveSpawnerEasy;
                }
                else if (difficuty = 2)
                {
                    WaveSpawenerMed;
                }
                else if (difficulty = 3)
                {
                    WaveSpawnerHard
                }
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

    void WaveSpawnerEasy
    {
        Instantiate()
    }
    void WaveSpawenerMed
    {
        Instantiate()
    }
void WaveSpawnerHard
    {
        Instantiate()
    }
}
