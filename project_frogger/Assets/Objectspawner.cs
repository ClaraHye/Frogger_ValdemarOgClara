using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Objectspawner : MonoBehaviour
{
    public Vector3 StartPosition;
    public Vector3 SlutPosition;
    public GameObject ObjectToSpawn;

    void Start()
    {
        SpawnObject();
    }
    public void SpawnObject()
    {
        float RandomSpeed = Random.Range(5, 10);
        GameObject log = Instantiate(ObjectToSpawn, StartPosition, Quaternion.identity);
        Destroy(log,RandomSpeed);
        log.GetComponent<Log_movement>().Move(RandomSpeed, StartPosition, SlutPosition);
        StartCoroutine(SpawnCooldown(RandomSpeed,log));
    }
    public IEnumerator SpawnCooldown(float speedcooldown, GameObject log)
    {
        yield return new WaitForSeconds(speedcooldown/2);
        SpawnObject();

    }

}

