using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenuPanel;
    public GameController gameController;

    // Start is called before the first frame update
    private void Start()
    {
        pauseMenuPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("Escape Pressed, Pausing Game");
            gameController.PauseGame();
            pauseMenuPanel.SetActive(true);
        }
    }
}
