using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxController : MonoBehaviour
{
    //Where we want the new object to be instantiated
    Vector3 desiredTransformPosition;

    // Camera
    public GameObject gameCameraObject;
    private Camera gameCamera;
    private Transform cameraTransform;
    private Vector3 screenBounds;

    // Dimensions of the background object
    private float objectWidth;
    public float choke = 0;


    // An array of background objects and their subsequent transforms
    public GameObject[] backgroundObjects = new GameObject[2];
    private Transform[] backgroundObjectTransforms = new Transform[2];


    // Start is called before the first frame update
    void Start()
    {
        //Figure out the screen bounds
        gameCamera = gameCameraObject.GetComponent<Camera>();
        cameraTransform = gameCamera.GetComponent<Transform>();
        screenBounds = gameCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cameraTransform.position.z));
        Debug.Log(screenBounds);

        loadChildObjects(backgroundObjects);
    }


    void loadChildObjects(GameObject[] backgroundObjects)
    {
        //assign all the transforms from the game objects to a seperate array so we dont need to do this every loop
        for (int i = 0; i < backgroundObjects.Length; i++)
        {
            Debug.Log(backgroundObjects.Length);
            backgroundObjectTransforms[i] = backgroundObjects[i].GetComponent<Transform>();
            
        }
        Debug.Log(backgroundObjectTransforms + "Transforms Loaded");
    }



    void RepositionObjects(Transform[] backgroundObjectTransforms, GameObject[] backgroundObjects)
    {
        // Go through all the background objects
        for (int i = 0; i < backgroundObjects.Length; i++)
        {
            // Figure out its length on the x axis
            objectWidth = backgroundObjects[i].GetComponent<MeshRenderer>().bounds.size.x - choke;

            // figure out if it needs to be regenerated
            if (backgroundObjectTransforms[i].position.x + screenBounds.x + 2 > (objectWidth / 2))
            {
                // And create a new one
                Debug.Log("Reposition required for : " + backgroundObjects[i].name);
                desiredTransformPosition = new Vector3(backgroundObjectTransforms[i].position.x + objectWidth, backgroundObjectTransforms[i].position.y, backgroundObjectTransforms[i].position.z);
                Instantiate(backgroundObjectTransforms[i], desiredTransformPosition, backgroundObjectTransforms[i].rotation);
            }
        }
    }


        // Update is called once per frame
        void Update()
    {
        RepositionObjects(backgroundObjectTransforms, backgroundObjects);
    }
}
