using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship
{
    /// <summary>
    /// Spaceship's maximum speed
    /// </summary>
    public int MaximumSpeed { get; set; }
    /// <summary>
    /// Color of ship
    /// </summary>
    public string Color { get; set; }


    /// <summary>
    /// Set Maximum Speed and Color
    /// </summary>
    /// <param name="maximumSpeed"></param>
    /// <param name="color"></param>
    public Spaceship(int maximumSpeed,string color)
    {
        MaximumSpeed = maximumSpeed;
        Color = color;
    }

    /// <summary>
    /// Set Maximum Speed
    /// </summary>
    /// <param name="maximumSpeed"></param>
    public Spaceship(int maximumSpeed)
    {
        MaximumSpeed = maximumSpeed;
        
    }

    /// <summary>
    /// It refers to make ship faster
    /// </summary>
    public void Boost()
    {
        MaximumSpeed += Random.Range(5, 20);
    }

    /// <summary>
    /// It refers to make ship slower
    /// </summary>
    public void MakeShipSlower()
    {
        MaximumSpeed-= Random.Range(5, 20);
    }


}
