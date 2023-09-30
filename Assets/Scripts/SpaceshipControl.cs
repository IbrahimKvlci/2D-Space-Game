using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipControl : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] GameObject _explosionPrefab;

    [SerializeField] const float _speed=7;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 bulletPos = gameObject.transform.position+Vector3.up;
            Instantiate(_bulletPrefab,bulletPos,Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(horizontal,vertical,0) * Time.deltaTime * _speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Asteroid")
        {
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
