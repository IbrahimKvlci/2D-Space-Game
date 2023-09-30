using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] List<GameObject> _spawnObjects;

    [SerializeField] int _spawnCount;
    [SerializeField] float _spawnDelay;



    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }


    void SpawnObject(GameObject gameObject)
    {
        Vector2 spawnPos = new Vector2(Random.Range(GetScreenSize.Left,GetScreenSize.Right),GetScreenSize.Top-1.5f);

        var spwanedObject =Instantiate(gameObject);
        spwanedObject.gameObject.transform.position = spawnPos;
        spwanedObject.transform.rotation = Quaternion.identity;
    }

    IEnumerator SpawnObjects()
    {
        for (int i = 0; i < _spawnCount; i++)
        {
            SpawnObject(_spawnObjects[Random.Range(0, _spawnObjects.Count)]);
            yield return new WaitForSeconds(_spawnDelay);
        }

    }
}
