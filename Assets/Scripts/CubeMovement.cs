using System.Collections;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [Header("References: ")]
    [SerializeField] private Rigidbody _rb;

    [Header("Properties: ")]
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(new Vector3(0, _jumpForce, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");
        _rb.velocity = new Vector3(mH * _speed, _rb.velocity.y, mV * _speed);
    }
}