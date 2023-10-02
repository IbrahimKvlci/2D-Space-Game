using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float y = 0.1f * Time.time;
        _meshRenderer.material.SetTextureOffset("_MainTex", new Vector2(0,y));   
    }
}
