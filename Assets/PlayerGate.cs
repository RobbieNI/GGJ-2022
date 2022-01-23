using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting;
using UnityEngine;
using UnityEngine.Events;

public class PlayerGate : MonoBehaviour
{
    [SerializeField] private int expectedMaterialIndex;
    [SerializeField] private bool shouldPlayerBeSphere;

    public UnityEvent OnGatePassed;

    public void CheckIfPlayerMaterialIsCorrect()
    {
        Debug.Log(TogglePlayers.CurrentStateIsSphere());
        if (TogglePlayers.CurrentStateIsSphere() != shouldPlayerBeSphere) return;
        
        Debug.Log("not correct shape");
        
        if (shouldPlayerBeSphere)
        {
            if (PlayerMaterialUpdate._currentSphereMaterialIndex == expectedMaterialIndex)
            {
                ActivateGate();
            }
        }
        else
        {
            if(PlayerMaterialUpdate._currentCubeMaterialIndex == expectedMaterialIndex)
            {
                Debug.Log("not correct material");

                ActivateGate();
            }
        }
    }

    private void ActivateGate()
    {
        OnGatePassed.Invoke();
    }
}
