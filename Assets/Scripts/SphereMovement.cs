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

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			_rb.AddForce(new Vector3(0, _jumpForce, 0), ForceMode.Impulse);
		}
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		_rb.AddForce(movement * _speed);
	}
}