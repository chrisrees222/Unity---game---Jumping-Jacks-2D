using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class play_DATA
{
    public int level;
    public int hearts;
    

    public play_DATA(Frog_Move frog)
    {
        level = frog.getLevel();
        hearts = frog.GetFrogLives();
    }
}
