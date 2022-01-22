using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SphereMovement : MonoBehaviour
{
	[Header("References: ")]
	[SerializeField] private Rigidbody _rb;

	[Header("Properties: ")]
	[SerializeField] private float _speed;
	[SerializeField] private float _jumpForce;
	[SerializeField] private float _fallMultiplier;
	[SerializeField] private float _lowJumpMultiplier;

	private void Update()
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

	void FixedUpdate()
	{
		
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		var actualMovement = Camera.main.transform.TransformDirection(movement);

		_rb.AddForce(actualMovement * _speed);
	}
}