using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private int speed = 10;

    public void Update()
    {
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += Movement * speed * Time.deltaTime;
    }
}
