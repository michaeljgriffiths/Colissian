using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToGameButton : MonoBehaviour
{

    public GameController gameController;
    public GameObject PauseGamePanel;
    
    public void OnClick()
    {
        returnToGame();
    }

    private void returnToGame()
    {
        PauseGamePanel.SetActive(false);
        gameController.UnPauseGame();
    }

}
