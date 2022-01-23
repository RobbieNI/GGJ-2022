using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SphereMovement : MonoBehaviour
{
	[Header("References: ")]
	[SerializeField] private Rigidbody _rb;
	[SerializeField] private CheckJumpCollision _jumpScript;
	[SerializeField] private AudioSource _moveAudio;

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

		if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0))
        {
			if (!_moveAudio.isPlaying)
            {
				_moveAudio.Play();
			}
		}
		else
        {
			_moveAudio.Stop();
		}
	}

	void FixedUpdate()
	{
		if (_inputEnabled)
        {
			float moveHorizontal = Input.GetAxis("Horizontal");
			float moveVertical = Input.GetAxis("Vertical");

			Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
			var actualMovement = Camera.main.transform.TransformDirection(movement);

			_rb.AddForce(actualMovement * _speed);
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
}