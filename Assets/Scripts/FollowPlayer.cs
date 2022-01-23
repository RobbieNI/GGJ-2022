using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Vector3 _offset = new Vector3(0, 5, 0);

    // Update is called once per frame
    void Update()
    {
        // The most unoptimised code Ive ever written
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        transform.position = Vector3.Lerp(transform.position, player.transform.position + _offset, Time.deltaTime);
        transform.LookAt(player.transform);
    }
}
