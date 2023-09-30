using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
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
    }
}
