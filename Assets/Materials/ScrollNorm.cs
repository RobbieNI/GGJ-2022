using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollNorm : MonoBehaviour {
   
    // Scroll bump map based on time

    float scrollSpeed = 0.5f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer> ();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_BumpMap", new Vector2(offset, 0));
    }
}
