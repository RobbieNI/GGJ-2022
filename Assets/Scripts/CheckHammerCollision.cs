using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckHammerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hammer"))
        {
            GameObject player = GameObject.FindWithTag("Player");
            Rigidbody rb = player.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(5000, 5000, 5000), ForceMode.Impulse);
        }
    }
}
