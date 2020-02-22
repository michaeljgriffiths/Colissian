using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Used during menu transitions to prevent the game loop from executing
    public void PauseGame()
    {
        Debug.Log("Pausing Game");
        Time.timeScale = 0;
    }

    public void UnPauseGame()
    {
        Debug.Log("UnPausing Game");
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
