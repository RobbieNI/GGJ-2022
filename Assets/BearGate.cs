using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BearGate : MonoBehaviour
{
    private bool isOpen = false;
    public UnityEvent OnGatePassedTrue;
    public UnityEvent OnGatePassedFalse;


    public void SetBearCorrect(bool trueOrFalse)
    {
        isOpen = trueOrFalse;
    }
    
    public void CheckIfBearIsCorrect()
    {
        if (isOpen)
        {
            OnGatePassedTrue.Invoke();
        }
        else
        {
            OnGatePassedFalse.Invoke();
        }
    }
}

