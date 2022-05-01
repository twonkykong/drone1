using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollLine : MonoBehaviour
{
    private Renderer _rend;
    private float _offset;

    [SerializeField]
    private float _scrollSpeed = 0.5f;

    private void Start()
    {
        _rend = GetComponent<Renderer>();
    }

    private void Update()
    {
        _offset += _scrollSpeed;
        _rend.material.SetTextureOffset("_MainTex", new Vector2(0, _offset));
    }
}
