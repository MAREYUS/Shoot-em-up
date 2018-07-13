﻿using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 0.5F;
    private Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
