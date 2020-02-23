using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalShot : MonoBehaviour
{
    public bool facingRight = true;
    public int force = 40;

    private void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (facingRight)
        {
            GetComponent<Rigidbody>().AddForce(transform.right * force);
        }
        else
        {
            GetComponent<Rigidbody>().AddForce(-transform.right * force);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
