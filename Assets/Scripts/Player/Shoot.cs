using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public GameObject projectile;
	public float force = 40;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			GameObject instance = Instantiate(projectile, new Vector3(transform.position.x + 1, transform.position.y, 0), Quaternion.identity) as GameObject;
			instance.AddComponent<HorizontalShot>();
		}
	}
}
