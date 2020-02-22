using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public GameObject backgroundPlane;
    private Transform backgroundTransform;
    public float speed;
    public GameObject gameCameraObject;
    private Camera gameCamera;
    private Transform cameraTransform;
    private int planeLength;
    public float choke = 0;

    Vector3 screenBounds;

    private void Start()
    {
        gameCamera = gameCameraObject.GetComponent<Camera>();
        backgroundTransform = backgroundPlane.GetComponent<Transform>();
        cameraTransform = gameCameraObject.GetComponent<Transform>();
        screenBounds = gameCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cameraTransform.position.z));
        Debug.Log(screenBounds.ToString());

        loadChildObjects(backgroundPlane);
    }

    void loadChildObjects(GameObject obj)
    {
        float objectWidth = obj.GetComponent<MeshRenderer>().bounds.size.x - choke;
        Debug.Log("Object width is : " + objectWidth.ToString());
        int childsNeeded = (int)Mathf.Ceil(screenBounds.x * 2 / objectWidth);
        Debug.Log("Objects needed is " + childsNeeded.ToString());

        GameObject clone = Instantiate(obj) as GameObject;
        //for (int i = 0; i <= childsNeeded; i++)
        {
            //GameObject c = Instantiate(clone) as GameObject;
            //c.transform.SetParent(obj.transform);
            //c.transform.position = new Vector3(objectWidth * i, obj.transform.position.y, obj.transform.position.z);
            //c.name = obj.name + i;
        }
        //Destroy(clone);
        //Destroy(obj.GetComponent<MeshRenderer>());


        // Update is called once per frame
        void Update()
        {
            backgroundTransform.position = new Vector3(backgroundTransform.position.x - 1 * speed * Time.deltaTime, backgroundTransform.position.y, 0);

        }
    }
}
