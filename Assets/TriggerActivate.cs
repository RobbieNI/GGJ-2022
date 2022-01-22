using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerActivate : MonoBehaviour
{
    private Collider _triggerCollider;
    public UnityEvent triggerActivation;

    protected void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ActivateTriggerEffect();
        }
    }

    protected virtual void ActivateTriggerEffect()
    {
        triggerActivation.Invoke();
    }

    protected virtual void Start()
    {
        Debug.Log("Start()");
    }
}
