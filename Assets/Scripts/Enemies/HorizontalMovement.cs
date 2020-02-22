﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public int force = 300;

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().AddForce(-transform.right * force);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
