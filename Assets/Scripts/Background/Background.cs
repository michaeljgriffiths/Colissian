using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public GameObject backgroundPlane;
    private Transform backgroundTransform;
    public float speed;

    private void Start()
    {
        backgroundTransform = backgroundPlane.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        backgroundTransform.position = new Vector3(backgroundTransform.position.x - 1 * speed * Time.deltaTime, backgroundTransform.position.y, 0);
        
    }
}
