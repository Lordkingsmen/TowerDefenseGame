using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicTower : MonoBehaviour
{
    public GameObject[] bulletPrefabs;
    public GameObject[] AllObjects;
    public GameObject NearestOBJ;
    public float distance;
    public float nearestDistance = 10;
    private bool cooldown;

    void Start()
    {
        
    }

    void Update()
    {
        AllObjects = GameObject.FindGameObjectsWithTag("EnemyGround");

        for (int i = 0; i < AllObjects.Length; i++)
        {
            distance = Vector3.Distance(this.transform.position, AllObjects[i].transform.position);
            if (distance <= nearestDistance)
            {
                NearestOBJ = AllObjects[i];
                if (Vector3.Distance(this.transform.position, NearestOBJ.transform.position) <= 10)
                {
                    if (!cooldown)
                    {
                        cooldown = true;
                        StartCoroutine("spawnBulletPrefabs");
                    }
                }
            }
        }
    }
    IEnumerator spawnBulletPrefabs()
    {
        int bulletIndex = Random.Range(0, bulletPrefabs.Length);
        Vector3 spawnPos = transform.position;
        Instantiate(bulletPrefabs[bulletIndex], spawnPos, bulletPrefabs[bulletIndex].transform.rotation);
        yield return new WaitForSeconds(1f);
        cooldown = false;
    }
}
