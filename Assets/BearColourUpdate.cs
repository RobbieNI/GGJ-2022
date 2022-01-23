using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearColourUpdate : MonoBehaviour
{
    private Renderer rend;
    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    public void UpdateColour(Material mat)
    {
        var mats = rend.materials;
        mats[1] = mat;
        rend.materials = mats;
    }
}
