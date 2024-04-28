using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    public GameObject mainMenuUI;

    public Camera_Move moveInCam;
    public GameObject resetScreen;
    public GameObject HowToImage;
    public GameObject creditsImage;

    //public GameObject Time_text;
    public countdown_lives countScript;



    public void OpenCreditsPage()
    {
        creditsImage.SetActive(true);
    }

    public void OpenHowToPlay()
    {
        HowToImage.SetActive(true);
    }

    public void loadGame()
    {

        if (save_Game.loadLevel() == null)
        {
            Frog_Move.level = 1;
            Frog_Move.frogLives = 5;
            SceneManager.LoadScene(Frog_Move.level);
        }
        else if(Frog_Move.frogLives == 0)
        {
            play_DATA data = save_Game.loadLevel();
            Frog_Move.level = data.level;
            Frog_Move.frogLives = data.hearts;
            countScript.startBool = true;
        }
        else         
        {
            play_DATA data = save_Game.loadLevel();
            Frog_Move.level = data.level;
            Frog_Move.frogLives = data.hearts;
            if (Frog_Move.frogLives != 0)
            {
                SceneManager.LoadScene(Frog_Move.level);
            }
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(Frog_Move.level);
    }

    public void ResetGame()
    {
        resetScreen.SetActive(true);
    }
    public void loadNewGame()
    {
        Frog_Move.level = 1;
        Frog_Move.frogLives = 5;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game.....");//quit game message displayed.
        
        Application.Quit(); //Quits the app, but only when compiled and not in editor hence the debug.log to stimulate it.
        
    }

    public void MainMenu()
    {
        Debug.Log("Menu Loading ....."); //sends console message that button is pressed and loading menu is displayed.
        SceneManager.LoadScene("MainMenu"); //loads the scene created withing the " ".
        
    }
}
