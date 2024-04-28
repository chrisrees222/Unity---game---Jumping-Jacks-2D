using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public bool GamePaused = false; //sets gamepaused to false for game to keep running.

    public Camera_Move camScript;

    public GameObject PauseScreen;
    public GameObject PauseButton;
    public GameObject jumpButton;
    public GameObject leftButton;
    public GameObject rightButton;
    //public GameObject BuyLivesMenu;
    


    private void Start()
    {
        Pause();
    }

    public void freezeGame()
    {
        if (GamePaused) // if game paused set to true
            {
                Time.timeScale = 1;// calls the resume method.
                GamePaused = false;
            }
            else
            {
                Time.timeScale = 0;//otherwise it calls the pause method.
                GamePaused = true;
                
            }
        PauseScreen.SetActive(true);
        PauseButton.SetActive(false);
        camScript.moveUp = false;
        
    }

    

    public void NextLevel()
    {
        SceneManager.LoadScene(Frog_Move.level);
    }

    public void PaymentMenu()
    {
        Debug.Log("Loading Menu .....");
        SceneManager.LoadScene("Pay_Lives_Menu");
    }

    public void Resume()
    {
        GamePaused = false;
        PauseScreen.SetActive(false);
        PauseButton.SetActive(true);
        leftButton.SetActive(true);
     
        jumpButton.SetActive(true);
        rightButton.SetActive(true);
        camScript.moveUp = true;
    }

    public void Pause()
    {
        GamePaused = true;
        PauseScreen.SetActive(true);
        PauseButton.SetActive(false);
        leftButton.SetActive(false);
        jumpButton.SetActive(false);
        rightButton.SetActive(false);
        camScript.moveUp = false;
    }

    public void buttonHide()
    {
        PauseButton.SetActive(false);
        leftButton.SetActive(false);
        jumpButton.SetActive(false);
        rightButton.SetActive(false);
    }

    public void LoadShareScreen()
    {
        SceneManager.LoadScene(8);
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu ....."); //sends console message that button is pressed and loading menu is displayed.
        SceneManager.LoadScene(0); //loads the scene created withing the " ".
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game.....");//quit game message displayed.
        Application.Quit(); //Quits the app, but only when compiled and not in editor hence the debug.log to stimulate it.        
    }

    public void restart()
    {
        if (Frog_Move.level == 1)
        {
            SceneManager.LoadScene(1);
            

        }
        else
        {
            play_DATA data = save_Game.loadLevel();
            Frog_Move.level = data.level;
            SceneManager.LoadScene(Frog_Move.level);
            
        }
        
    }
}

