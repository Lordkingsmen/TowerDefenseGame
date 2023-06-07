using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Vector3 mover = new Vector3(0, 0, 0.5f);
    private int moveCount = 3;
    private float moveTime = 0.5f;
    void Start()
    {
        
    }
    void FixedUpdate()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spawner" || other.tag == "Path")
        {
            this.transform.forward = other.transform.forward;
            StartCoroutine("Pathing");
        }
        else if (other.tag == "Bullet")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if(other.tag == "End")
        {
            Destroy(gameObject);
        }
    }
    IEnumerator Pathing()
    { 
        for(int i = 0; i < moveCount; i++)
        {
            yield return new WaitForSeconds(moveTime);
            transform.Translate(mover);
        }
    }
}
