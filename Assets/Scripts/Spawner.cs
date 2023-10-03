using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] List<GameObject> _spawnObjectsPrefab;

    [SerializeField] int _spawnCount;
    [SerializeField] float _spawnDelay;

    public List<GameObject> _spawnObjects;

    GameControl _gameControl;

    private void Start()
    {
        _gameControl = gameObject.GetComponent<GameControl>();
        _spawnObjects = new List<GameObject>();

        
    }


    void SpawnObject(GameObject gameObject)
    {
        Vector2 spawnPos = new Vector2(Random.Range(GetScreenSize.Left, GetScreenSize.Right), GetScreenSize.Top - 1.5f);

        var spwanedObject = Instantiate(gameObject);
        _spawnObjects.Add(spwanedObject);
        spwanedObject.gameObject.transform.position = spawnPos;
        spwanedObject.transform.rotation = Quaternion.identity;
    }

    public IEnumerator SpawnObjects()
    {
        
        for (int i = 0; i < _spawnCount; i++)
        {
            if (!_gameControl._isGameFinished)
            {
                SpawnObject(_spawnObjectsPrefab[Random.Range(0, _spawnObjectsPrefab.Count)]);
                yield return new WaitForSeconds(_spawnDelay);
            }
            else
            {
                break;
            }
  
        }

    }

    
}
