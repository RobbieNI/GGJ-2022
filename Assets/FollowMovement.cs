using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMovement : MonoBehaviour
{
    public Transform target;
    
    [SerializeField] private float speed = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(target.position,target.position,speed * Time.deltaTime);
    }
    
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
