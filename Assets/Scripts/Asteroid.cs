using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] GameObject _explosionPrefab;

    private Rigidbody2D _rb;


    UIControl _uiControl;

    Spawner _spawner;

    private void Start()
    {
        _uiControl = GameObject.FindGameObjectWithTag("GameController").GetComponent<UIControl>();
        if (gameObject.GetComponent<Rigidbody2D>() != null)
        {
            _rb = gameObject.GetComponent<Rigidbody2D>();
        }
        else
        {
            _rb = gameObject.AddComponent<Rigidbody2D>();
        }
        _spawner = GameObject.FindGameObjectWithTag("GameController").GetComponent<Spawner>();
        _rb.AddForce(new Vector2(Random.Range(-2, 2), Random.Range(-2, -5)), ForceMode2D.Impulse);
        _rb.AddTorque(Random.Range(0, 10));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioControl>().AsteroidExplosionAudio();
            _uiControl.AsteroidDestroyed(gameObject);
            _spawner._spawnObjects.Remove(gameObject);
            DestroyAsteroid();
        }
    }

    public void DestroyAsteroid()
    {
        Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
