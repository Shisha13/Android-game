using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScr : MonoBehaviour {

    public bool IsSameDelay;
    public bool IsSameObjects;
    public GameObject ObjToSpawn;
    public GameObject[] ObjsToSpawn;
    public float TimeBeforeSpawn;
    public float SpawnDelay;
    public float MinDelay;
    public float MaxDelay;


    private void Start()
    {
        if(IsSameDelay)
        {
            InvokeRepeating("Spawn", TimeBeforeSpawn, SpawnDelay);
        }
        else
        {
            StartCoroutine(Spawner());
        }
       
    }
       IEnumerator Spawner()
    {
        yield return new WaitForSeconds(Random.Range(MinDelay, MaxDelay));
        Spawn();
    }

    void Spawn()
    {
        if (!IsSameObjects)
        {
            GameObject obj = Instantiate(ObjsToSpawn[Random.Range(0, ObjsToSpawn.Length)], transform.position, transform.rotation) as GameObject;
        }
        if (IsSameObjects)
        {
            GameObject obj = Instantiate(ObjToSpawn, transform.position, transform.rotation) as GameObject;
        }
        if(!IsSameDelay)
        {
            StartCoroutine(Spawner());
        }
        
    }
}
