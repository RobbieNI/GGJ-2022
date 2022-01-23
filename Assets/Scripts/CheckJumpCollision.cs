using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckJumpCollision : MonoBehaviour
{
    public bool _canJump;

    private void OnCollisionStay(Collision collision)
    {
        _canJump = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        _canJump = false;
    }
}