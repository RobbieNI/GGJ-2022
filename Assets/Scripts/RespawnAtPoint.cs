using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnAtPoint : MonoBehaviour
{
    [SerializeField] private Transform _respawnPoint;

    [Header("Players: ")]
    [SerializeField] private GameObject _sphere;
    [SerializeField] private GameObject _cube;

    public void ResetAtPoint()
    {
        _sphere.transform.position = _respawnPoint.position;
        _cube.transform.position = _respawnPoint.position;
    }
}