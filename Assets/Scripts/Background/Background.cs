using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public float speed;
    public GameObject gameCameraObject;
    private Camera gameCamera;
    private Transform cameraTransform;
    public float choke = 0;
    private float objectWidth;

    public GameObject[] backgroundObjects = new GameObject[2];
    private Transform[] backgroundObjectTransforms = new Transform[2];

    Vector3 screenBounds;
    Vector3 desiredTransformPosition;

    private void Start()
    {
        gameCamera = gameCameraObject.GetComponent<Camera>();
        cameraTransform = gameCamera.GetComponent<Transform>();
        screenBounds = gameCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cameraTransform.position.z));
        Debug.Log(screenBounds.ToString());

        loadChildObjects(backgroundObjects);
    }

    void loadChildObjects(GameObject [] backgroundObjects)
    {
        //assign all the transforms from the game objects to a seperate array so we can work with them directly
        for (int i = 0; i < backgroundObjects.Length; i++)
        {
            Debug.Log(backgroundObjects.Length);
            backgroundObjectTransforms[i] = backgroundObjects[i].GetComponent<Transform>();
            Debug.Log(backgroundObjectTransforms[i]);
        }
        
    }

    void RepositionObjects(Transform [] backgroundObjectTransforms, GameObject [] backgroundObjects)
    {
        for (int i = 0; i < backgroundObjects.Length; i++)
        {
            objectWidth = backgroundObjects[i].GetComponent<MeshRenderer>().bounds.size.x - choke;

            if (backgroundObjectTransforms[i].position.x + screenBounds.x + 2 < objectWidth)
            {
                Debug.Log("Reposition required for : " + backgroundObjects[i].name);
                desiredTransformPosition = new Vector3(backgroundObjectTransforms[i].position.x + objectWidth, backgroundObjectTransforms[i].position.y, backgroundObjectTransforms[i].position.z);
                Instantiate(backgroundObjectTransforms[i], desiredTransformPosition, backgroundObjectTransforms[i].rotation);
            }
        }




            

 
    }

    void MoveBackgrounds(Transform [] backgroundObjectTransforms)
    {
        for (int i = 0; i < backgroundObjectTransforms.Length; i++)
        backgroundObjectTransforms[i].position = new Vector3(backgroundObjectTransforms[i].position.x - 1 * speed * Time.deltaTime, backgroundObjectTransforms[i].position.y, backgroundObjectTransforms[i].position.z);
    }



    // Update is called once per frame
    void Update()
    {

    MoveBackgrounds(backgroundObjectTransforms);
    //RepositionObjects(backgroundObjectTransforms, backgroundObjects);
    }
   }

