using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToPlayer : MonoBehaviour
{
    private void OnEnable()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        transform.position = player.transform.position;
    }
}
