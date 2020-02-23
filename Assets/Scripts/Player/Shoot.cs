using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public bool facingRight = true;
	public GameObject projectile;
	public float force = 40;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			facingRight = true;
		} 
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			facingRight = false;
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject instance = null;
			if (facingRight)
			{
				instance = Instantiate(projectile, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity) as GameObject;
			}
			else
			{
				instance = Instantiate(projectile, new Vector3(transform.position.x - 1, transform.position.y, 0), Quaternion.identity) as GameObject;
			}

			instance.AddComponent<HorizontalShot>();
			HorizontalShot shotScript = instance.GetComponent<HorizontalShot>();
			shotScript.facingRight = facingRight;
		}
	}
}
