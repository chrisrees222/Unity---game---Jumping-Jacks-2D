using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Over : MonoBehaviour
{
    public static bool gameFreeze;
    public GameObject gameOver;
    public Frog_Move frogSave;
    public GameObject PauseButton;
    public GameObject zeroLives;

    // Start is called before the first frame update
    void Start()
    {
        
        gameFreeze = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFreeze) // if game paused set to true
        {
            Time.timeScale = 0;// calls the resume method.
        }
        else
        {
            Time.timeScale = 1;//otherwise it calls the pause method.
        }

        if(Frog_Move.frogLives < 1)
        {
            gameFreeze = true;
            zeroLives.SetActive(true);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)//if the frog collider collides with mainCamera Tagged collider
    {
        if (collision.gameObject.tag == "Player")
        {

            gameFreeze = true;
            Frog_Move.frogLives -= 1;
            frogSave.SavePlayerPos();
            PauseButton.SetActive(false);
            if(Frog_Move.frogLives >= 1)
            {
                gameOver.SetActive(true);
                frogSave.SavePlayerPos();
            }
            else
            {
                zeroLives.SetActive(true);                
            }
        }
    }
}
