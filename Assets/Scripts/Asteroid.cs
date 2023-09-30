using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] GameObject _explosionPrefab;

    private Rigidbody2D _rb;

    private void Start()
    {
        if (gameObject.GetComponent<Rigidbody2D>()!=null)
        {
            _rb = gameObject.GetComponent<Rigidbody2D>();
        }
        else
        {
            _rb=gameObject.AddComponent<Rigidbody2D>();
        }

        _rb.AddForce(new Vector2(Random.Range(-2, 2), Random.Range(-2, -5)),ForceMode2D.Impulse);
        _rb.AddTorque(Random.Range(0, 10));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
