using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{

    [SerializeField] GameObject _gameNameText;
    [SerializeField] GameObject _gameOverText;
    [SerializeField] GameObject _playButton;

    [SerializeField] TextMeshProUGUI _scoreText;

    int _score;

    void Start()
    {
        _gameOverText.gameObject.SetActive(false);
    }

    public void GameStarted()
    {
        _gameNameText.gameObject.SetActive(false);
        _gameOverText.gameObject.SetActive(false);
        _playButton.gameObject.SetActive(false);
    }

    void UpdateScore()
    {
        _scoreText.text =$"SCORE : {_score.ToString()}" ;
    }

    public void AsteroidDestroyed(GameObject asteroid)
    {
        switch (asteroid.gameObject.name[8])
        {
            case '2':
                _score += 5;
                UpdateScore();
                break;
            case '3':
                _score += 10;
                UpdateScore();
                break;


            default:
                break;
        }
    }
}
