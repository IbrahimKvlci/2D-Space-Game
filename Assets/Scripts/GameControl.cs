using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject _spaceshipPrefab;

    GameObject _spaceShip;

    Spawner _spawner;

    UIControl _uiControl;

    public bool _isGameFinished=false;

    private void Awake()
    {
        GetScreenSize.Init();
    }

    private void Start()
    {
        _spawner= GetComponent<Spawner>();
        _uiControl= GetComponent<UIControl>();
    }

    public void StartGame()
    {
        _isGameFinished=false;
        _uiControl.GameStarted();
        _spaceShip = Instantiate(_spaceshipPrefab);
        _spaceShip.transform.position = new Vector3(0, GetScreenSize.Bottom + 1.5f, 0);
        StartCoroutine(_spawner.SpawnObjects());
    }

    public  void FinishGame()
    {
        _isGameFinished=true;
        foreach (var asteroid in _spawner._spawnObjects)
        {
            asteroid.GetComponent<Asteroid>().DestroyAsteroid();
        }
        _spawner._spawnObjects.Clear();
        _uiControl.GameOver();
    }
}
