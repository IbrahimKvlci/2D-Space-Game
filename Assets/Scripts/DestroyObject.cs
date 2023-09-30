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

        _timer.TotalTime = 1;
        _timer.Run();
    }


    void Update()
    {
        if (_timer.IsFinished)
        {
            Destroy(gameObject);
        }
    }
}
