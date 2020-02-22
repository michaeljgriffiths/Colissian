using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalShot : MonoBehaviour
{
    public int force = 40;

    private void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(transform.right * force);
    }
}
