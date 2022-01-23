using System.Collections;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [Header("References: ")]
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private CheckJumpCollision _jumpScript;

    [Header("Properties: ")]
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _fallMultiplier;
    [SerializeField] private float _lowJumpMultiplier;

    private bool _inputEnabled;


    private void Awake()
    {
        _inputEnabled = true;

        PlayerRespawn._toggleInput += ToggleInput;
    }

    private void OnDestroy()
    {
        PlayerRespawn._toggleInput -= ToggleInput;
    }

    private void Update()
    {
        if (_inputEnabled && _jumpScript._canJump)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rb.AddForce(new Vector3(0, _jumpForce, 0), ForceMode.Impulse);
            }

            if (_rb.velocity.y < 0)
            {
                _rb.velocity += Vector3.up * Physics.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;
            }
            else if (_rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
            {
                _rb.velocity += Vector3.up * Physics.gravity.y * (_lowJumpMultiplier - 1) * Time.deltaTime;
            }
        }
    }

    public void ToggleInput(bool state)
    {
        if (state)
        {
            _inputEnabled = true;
        }
        else
        {
            _inputEnabled = false;
        }
    }

    void FixedUpdate()
    {
        if (_inputEnabled)
        {
            float mH = Input.GetAxis("Horizontal");
            float mV = Input.GetAxis("Vertical");

            _rb.velocity = new Vector3(mH * _speed, _rb.velocity.y, mV * _speed);
        }
    }
}