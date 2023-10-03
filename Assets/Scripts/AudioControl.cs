using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    [SerializeField] AudioClip _asteroidExplosion;
    [SerializeField] AudioClip _shipExplosion;
    [SerializeField] AudioClip _fire;

    AudioSource _audioSource;


    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    public void AsteroidExplosionAudio()
    {
        _audioSource.PlayOneShot(_asteroidExplosion);
    }

    public void ShipExplosionAudio()
    {
        _audioSource.PlayOneShot(_shipExplosion);
    }
    public void FireAudio()
    {
        _audioSource.PlayOneShot(_fire,0.2f);
    }
}
