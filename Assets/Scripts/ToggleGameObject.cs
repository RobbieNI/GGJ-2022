using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObject : MonoBehaviour
{
    [SerializeField] private GameObject _objToToggle;

    protected virtual void Awake()
    {
        PlayerRespawn._toggleDeathScreen += Toggle;
    }

    protected virtual void OnDestroy()
    {
        PlayerRespawn._toggleDeathScreen -= Toggle;
    }

    public void Toggle()
    {
        if (_objToToggle.activeInHierarchy)
        {
            _objToToggle.SetActive(false);
        }
        else
        {
            _objToToggle.SetActive(true);
        }
    }
}