using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	public int forceConst = 7;
	public bool grounded = true;

	private new Rigidbody rigidbody;

	// Start is called before the first frame update
	void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		rigidbody.freezeRotation = true;
	}

	// Update is called once per frame
	void Update()
	{
		if (grounded)
		{
			if (Input.GetAxis("Vertical") > 0)
			{
				grounded = false;
				rigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
			}
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Ground"))
		{
			grounded = true;
		}
	}

	void OnCollisionExit(Collision other)
	{
		if (other.gameObject.CompareTag("Ground"))
		{
			grounded = false;
		}
	}
}
