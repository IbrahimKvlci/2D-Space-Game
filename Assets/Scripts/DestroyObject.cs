using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    Timer _timer;

    void Start()
    {
        if (gameObject.GetComponent<Timer>() != null)
        {
            _timer=gameObject.GetComponent<Timer>();
        }
        else
        {
            _timer=gameObject.AddComponent<Timer>();
        }

        _timer.TotalTime = Random.Range(5, 20);
        _timer.Run();
    }

    void DestroyObjectWhenTimeFinished()
    {
        if (_timer.IsFinished)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        DestroyObjectWhenTimeFinished();
    }
}
