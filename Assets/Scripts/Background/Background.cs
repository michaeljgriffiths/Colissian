using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public float speed;
    public GameObject backgroundObject;
    private Transform backgroundObjectTransform;

    private void Start()
    {
        backgroundObjectTransform = backgroundObject.GetComponent<Transform>();
    }



    void MoveBackground(Transform backgroundObjectTransform)
    {
        backgroundObjectTransform.position = new Vector3(backgroundObjectTransform.position.x - 1 * speed * Time.deltaTime, backgroundObjectTransform.position.y, backgroundObjectTransform.position.z);
    }



    // Update is called once per frame
    void Update()
    {
    MoveBackground(backgroundObjectTransform);
    }
   }

