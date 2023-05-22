using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //combine the same ones later
        if (other.tag == "Spawner")
        {
            transform.Rotate = other.Rotate;
        }
        /*else (other.tag == "Straight")
        {
            transform.eulerAngles = other.eulerAngles;
        }
        else (other.tag == "Right Turn")
        {
            transform.eulerAngles = other.eulerAngles;
        }
        else (other.tag == "Left Turn")
        {
            transform.eulerAngles = other.eulerAngles;
        }
        else (other.tag == "T Merge")
        {
            transform.eulerAngles = other.eulerAngles;
        }
        else (other.tag == "T Center")
        {
            transform.eulerAngles = other.eulerAngles;
        }
        else (other.tag == "X Path")
        {
            transform.eulerAngles = other.eulerAngles;
        }*/
    }
}
