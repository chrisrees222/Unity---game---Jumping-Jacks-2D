using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLevelObject : MonoBehaviour
{
    
    public Camera_Move camScript;
    public GameObject winnerScreen;
    public Pause_Menu pauseScript;
    public Frog_Move frogSave;
    //public Ad_Manager Advert;

    

    
    void OnCollisionEnter2D(Collision2D collision)//if the frog collides with the tagged levelObject, destroys the object.
        {            
            if (collision.gameObject.tag == "Player")
            {
                frogSave.IncreaseLives();
                frogSave.IncrementLevel();            
                winnerScreen.SetActive(true);
                camScript.moveUp = false;
                pauseScript.buttonHide();                
                Destroy(gameObject);
                frogSave.SavePlayerPos();
            }
        }
    
}
