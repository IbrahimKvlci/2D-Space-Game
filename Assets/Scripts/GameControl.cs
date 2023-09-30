using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject _spaceshipPrefab;

    GameObject _spaceShip;

    private void Awake()
    {
        GetScreenSize.Init();
    }

    private void Start()
    {
        _spaceShip = Instantiate(_spaceshipPrefab);
        _spaceShip.transform.position = new Vector3(0, GetScreenSize.Bottom+1.5f, 0);
    }
}
