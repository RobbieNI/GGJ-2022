using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    private void OnEnable()
    {
        transform.position = player.position;
    }
}
