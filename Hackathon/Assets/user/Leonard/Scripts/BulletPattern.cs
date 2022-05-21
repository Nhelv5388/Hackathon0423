using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletPattern : MonoBehaviour
{
    public GameObject Missile;
    public float timeToSpawn;
    private float currentTimeToSpawn;
    private Quaternion rot;

    void Start()
    {
        rot = new Quaternion(0, 0, 0 ,0);
    }

    void Update()
    {
        if(currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }
    }

    private void SpawnObject()
    {
        Missile = Instantiate(Missile, transform.position, rot);
        rot.eulerAngles += new Vector3(0, 0, 5);
    }
}
