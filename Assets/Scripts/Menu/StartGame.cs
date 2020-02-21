using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartGame : MonoBehaviour
{

    //Set a default scene name that can be overriden in the console if needed
    public string sceneName = "GameScene";


    public void OnClick()
    {
        ChangeScene();
    }

    private void ChangeScene()
    {
        Debug.Log("Opening Scene: " + sceneName);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
