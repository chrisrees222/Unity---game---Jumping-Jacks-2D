using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buy_Lives_Menu : MonoBehaviour
{
    
    public void BuyTenLives()
    {
        Frog_Move.frogLives = Frog_Move.frogLives + 15;
        SceneManager.LoadScene(Frog_Move.level);
    }

    public void BuyTwentyLives()
    {
        Frog_Move.frogLives = Frog_Move.frogLives + 30;
        SceneManager.LoadScene(Frog_Move.level);
    }

    public void BuyFortyLives()
    {
        Frog_Move.frogLives = Frog_Move.frogLives + 50;
        SceneManager.LoadScene(Frog_Move.level);
    }


    public void BackToScene()
    {
        SceneManager.LoadScene(Frog_Move.level);
        Game_Over.gameFreeze = true;        
    }

    

}
