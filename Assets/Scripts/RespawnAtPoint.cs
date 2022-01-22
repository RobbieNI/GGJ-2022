using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAtPoint : MonoBehaviour
{
    [SerializeField] private Transform _respawnPoint;
    public static Action<Transform> respawnAtPoint;

    public void ResetAtPoint()
    {
        respawnAtPoint?.Invoke(_respawnPoint);
    }
}