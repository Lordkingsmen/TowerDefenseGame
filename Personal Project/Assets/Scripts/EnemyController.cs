using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Vector3 mover = new Vector3(0, 0, 0.5f);
    private int iterationCount = 3;
    private float moveTime = 0.5f;
    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spawner" || other.tag == "Straight")
        {
            StartCoroutine("Straight");
            other.transform.Rotate = this.transform.Rotate;
        }
        else if (other.tag == "Right Turn")
        {
            StartCoroutine("RightTurn");
        }
        else if (other.tag == "Left Turn")
        {
            StartCoroutine("Straight");
        }
        else if (other.tag == "T Merge")
        {
            StartCoroutine("Straight");
        }
        else if (other.tag == "T Center")
        {
            StartCoroutine("Straight");
        }
        else if (other.tag == "X Path")
        {
            StartCoroutine("Straight");
        }
    }

    IEnumerator Straight()
    { 
        for(int i = 0; i < iterationCount; i++)
        {
            yield return new WaitForSeconds(moveTime);
            transform.Translate(mover);
        }
    }
    IEnumerator RightTurn()
    {
        for (int i = 0; i < iterationCount; i++)
        {
            if (i == 0)
            {
                transform.Rotate(0.0f, -90.0f, 0.0f);
            }
            yield return new WaitForSeconds(moveTime);
            transform.Translate(mover);
        }
    }
}
