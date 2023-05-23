using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Vector3 mover = new Vector3(0, 0, 0.5f);
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spawner")
        {
            Straight();
        }
        else if (other.tag == "Straight")
        {
            Straight();
        }
        else if (other.tag == "Right Turn")
        {
            Straight();
        }
        else if (other.tag == "Left Turn")
        {
            Straight();
        }
        else if (other.tag == "T Merge")
        {
            Straight();
        }
        else if (other.tag == "T Center")
        {
            Straight();
        }
        else if (other.tag == "X Path")
        {
            Straight();
        }
    }

    private void Straight()
    { 
        transform.Translate(mover);
    }
}
