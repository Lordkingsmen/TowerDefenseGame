using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicTower : MonoBehaviour
{
    public GameObject[] AllObjects;
    public GameObject NearestOBJ;
    float distance;
    float nearestDistance = 10;


    void Start()
    {

    }

    void Update()
    {
        AllObjects = GameObject.FindGameObjectsWithTag("EnemyGround");

        for (int i = 0; i < AllObjects.Length; i++)
        {
            distance = Vector3.Distance(this.transform.position, AllObjects[i].transform.position);

            if (distance < nearestDistance)
            {
                NearestOBJ = AllObjects[i];
                nearestDistance = distance;
            }
        }
    }
}
