using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public GameObject backgroundPlane;
    private Transform backgroundTransform;

    private void Start()
    {
        backgroundTransform = backgroundPlane.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        backgroundTransform.position = new Vector3(backgroundTransform.position.x - 1 * 2 * Time.deltaTime, backgroundTransform.position.y, 0);
        
    }
}
