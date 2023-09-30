using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Timer _timer;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10),ForceMode2D.Impulse);
        _timer=gameObject.AddComponent<Timer>();
        _timer.TotalTime = 3;
        _timer.Run();
    }

    private void Update()
    {
        if (_timer.IsFinished)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
    }

}
