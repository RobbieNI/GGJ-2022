using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivateButtonPress : TriggerActivate
{
    private bool inTriggerZone;

    public static Action<string> inInteractiveTriggerZone;
    public static Action leavingInteractiveTriggerZone;

    protected override void ActivateTriggerEffect()
    {
        inTriggerZone = true;
        inInteractiveTriggerZone?.Invoke("Press Space Bar");
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            inTriggerZone = false;
            leavingInteractiveTriggerZone?.Invoke();
        }
    }

    private void Update()
    {
        if(!inTriggerZone) return;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            base.ActivateTriggerEffect();
        }
    }
}
